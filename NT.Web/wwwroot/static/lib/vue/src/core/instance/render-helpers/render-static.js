/* @flow */

import { cloneVNode, cloneVNodes } from 'core/vdom/vnode'

/**
 * Runtime helper for rendering static trees.
 */
export function renderStatic (
  index: number,
  isInFor: boolean,
  isOnce: boolean
): VNode | Array<VNode> {
  // render fns generated by compiler < 2.5.4 does not provide v-once
  // information to runtime so be conservative
  const isOldVersion = arguments.length < 3
  // if a static tree is generated by v-once, it is cached on the instance;
  // otherwise it is purely static and can be cached on the shared options
  // across all instances.
  const renderFns = this.$options.staticRenderFns
  const cached = isOldVersion || isOnce
    ? (this._staticTrees || (this._staticTrees = []))
    : (renderFns.cached || (renderFns.cached = []))
  let tree = cached[index]
  // if has already-rendered static tree and not inside v-for,
  // we can reuse the same tree by doing a shallow clone.
  if (tree && !isInFor) {
    return Array.isArray(tree)
      ? cloneVNodes(tree)
      : cloneVNode(tree)
  }
  // otherwise, render a fresh tree.
  tree = cached[index] = renderFns[index].call(this._renderProxy, null, this)
  markStatic(tree, `__static__${index}`, false)
  return tree
}

/**
 * Runtime helper for v-once.
 * Effectively it means marking the node as static with a unique key.
 */
export function markOnce (
  tree: VNode | Array<VNode>,
  index: number,
  key: string
) {
  markStatic(tree, `__once__${index}${key ? `_${key}` : ``}`, true)
  return tree
}

function markStatic (
  tree: VNode | Array<VNode>,
  key: string,
  isOnce: boolean
) {
  if (Array.isArray(tree)) {
    for (let i = 0; i < tree.length; i++) {
      if (tree[i] && typeof tree[i] !== 'string') {
        markStaticNode(tree[i], `${key}_${i}`, isOnce)
      }
    }
  } else {
    markStaticNode(tree, key, isOnce)
  }
}

function markStaticNode (node, key, isOnce) {
  node.isStatic = true
  node.key = key
  node.isOnce = isOnce
}