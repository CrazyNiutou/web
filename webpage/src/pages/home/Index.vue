<template>
<div>
  <div class="line"></div>  
  <el-row :gutter="20">
    <el-col :span="6">
      <div class="grid-content bg-purple">
        <div class="wrap">
          <span class="wrap_img">
            <img src="static/img/common_65_icon.jpg" />
          </span>
          <div class="tabl_1_title">
            <ul>
              <li style="font-size:16px;font-weight:600">
                <a href="#"> <router-link to="/content/Articles">Red Net</router-link></a>
              </li>
              <li>帖子:{{500}}</li>
            </ul>
          </div>
        </div>
      </div>
    </el-col>
    <el-col :span="6">
      <div class="grid-content bg-purple">
           <div class="wrap">
          <span class="wrap_img">
            <img src="static/img/common_65_icon.jpg" />
          </span>
          <div class="tabl_1_title">
            <ul>
              <li style="font-size:16px;font-weight:600">
                <a href="#">Model</a>
              </li>
              <li>帖子:{{500}}</li>
            </ul>
          </div>
        </div>
      </div>
    </el-col>
    <el-col :span="6">
      <div class="grid-content bg-purple">
           <div class="wrap">
          <span class="wrap_img">
            <img src="static/img/common_65_icon.jpg" />
          </span>
          <div class="tabl_1_title">
            <ul>
              <li style="font-size:16px;font-weight:600">
                <a href="#">VR</a>
              </li>
              <li>帖子:{{500}}</li>
            </ul>
          </div>
        </div>
      </div>
    </el-col>
    <el-col :span="6">
      <div class="grid-content bg-purple">
        <div id="test111">
          <span v-bind:title="message">
            鼠标悬停几秒钟查看此处动态绑定的提示信息！
          </span>
        </div>
      </div>
    </el-col>
  </el-row>
</div>
</template>


<script>
export default {
  name: "HomeIndex",
  data(){
    return{
      message:'123'
    }
  }
};
 
</script>

<style>
.line{
  border-bottom: 1px;
  border-bottom-color: black;
}
.wrap { 
    display: flex;
    justify-content: flex-start; 
     margin-left: 30px;
     padding-top: 8px;
} 
 
</style>


