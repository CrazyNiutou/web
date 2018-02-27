import Vue from 'vue'
import Router from 'vue-router'
import HomeIndex from '@/pages/home/Index'  
import ContentArticles from '@/pages/content/Articles'
import MemberLink from '@/pages/member/Members'
import AccountLink from '@/pages/account/Account'

Vue.use(Router)

export default new Router({
  routes: [
    {
      path: '/',
      name: 'HomeIndex',
      component: HomeIndex
    }  ,
    {
      path:'/content/articles',
      component:ContentArticles
    },
    {
      path:'/member/Members',
      component:MemberLink
    },
    {
      path:'/account/Account',
      component:AccountLink
    }
  ]
})
