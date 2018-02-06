<template>
  <div id="app">
    <el-container>
      <el-header>
        <div class="line"></div>
        <el-menu :default-active="activeIndex" class="el-menu-demo" mode="horizontal" @select="handleSelect">
          <span class="left logo">
            <img src="../static/img/logo.png" />
          </span>
          <el-menu-item index="1">首页</el-menu-item>
          <el-menu-item index="2">社区</el-menu-item>
          <!-- <el-submenu index="2">
            <template slot="title">我的工作台</template>
            <el-menu-item index="2-1">选项1</el-menu-item>
            <el-menu-item index="2-2">选项2</el-menu-item>
            <el-menu-item index="2-3">选项3</el-menu-item>
          </el-submenu> -->
          <el-menu-item index="3">
            <a href="#" target="_blank">会员</a>
          </el-menu-item>
        </el-menu>
      </el-header>
      <el-main>
        <router-view/>
      </el-main>
      <el-footer id="footer">
        <p id="p1">
          <span>
            本网站版权归站长所有。
          </span>
          <br />
        </p>
        <p id="p2">
          <span>
            当使用本站时，代表您已接受了本站的使用条款和隐私条款。版权所有，保留一切权利。
          </span>
        </p>
      </el-footer>
    </el-container>
  </div>
</template>

<script>
  export default {
    name: "App"
  };

  import "element-ui/lib/theme-chalk/index.css";

</script>

<style>
  #app {
    font-family: "Avenir", Helvetica, Arial, sans-serif;
    -webkit-font-smoothing: antialiased;
    -moz-osx-font-smoothing: grayscale;
    text-align: center;
    color: #2c3e50;
  }

  .logo {
    float: left;
    padding-left: 10px;
    padding-right: 50px;
  }

  #footer {
    position: absolute;
    bottom: 0;
    width: 100%;
    /* Set the fixed height of the footer here */
    height: 60px;
    background-color: #f5f5f5;
  }

  #footer #p1 {
    margin-top: 10px;
    font-size: 12px;
    text-align: center;
  }

  #footer #p2 {
    margin-top: 10px;
    font-size: 12px;
    text-align: center;
  }

</style>
