<template>
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
        
      </div>
    </el-col>
  </el-row>

</template>

<style>
.wrap { 
    display: flex;
    justify-content: flex-start; 
     margin-left: 30px;
     padding-top: 8px;
} 
 
</style>


<script>
export default {
  name: "HomeIndex"
};

// axios.get('http://localhost:63155/Account/Login?userName=123&pwd=22')
// .then(function(respone){
//   console.log(response);
// })
// .catch(function(error){
//   console.log(error);
// });
</script>
