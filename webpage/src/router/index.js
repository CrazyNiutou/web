import Vue from 'vue'
import Router from 'vue-router'
// import HelloWorld from '@/components/HelloWorld'
import HomeIndex from '@/pages/home/Index'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HomeIndex',
      component: HomeIndex
    },
    {
      path: '/home',
      name: 'HomeIndex',
      component: HomeIndex
    },
    {
      path: '/account',
      name: 'HomeIndex',
      component: HomeIndex
    }
  ]
})
