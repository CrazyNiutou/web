<template> 
<el-row :gutter="20">
  <el-col :span="6">
    <div class="grid-content bg-purple">
              <div class="tab_1_img">
            <img src="../static/img/common_65_icon.jpg" />
        </div>
        <div class="tabl_1_title">
            <ul>
                <li style="font-size:16px;font-weight:600"><a href="#">Red Net</a></li>
                <li>帖子:{{500}}</li>
            </ul>
        </div>
    </div>
    </el-col>
  <el-col :span="6"><div class="grid-content bg-purple"></div></el-col>
  <el-col :span="6"><div class="grid-content bg-purple"></div></el-col>
  <el-col :span="6"><div class="grid-content bg-purple"></div></el-col>
</el-row>

</template>

<style>
  .el-row {
    margin-bottom: 20px;
    &:last-child {
      margin-bottom: 0;
    }
  }

  .el-col {
    border-radius: 4px;
  }

  .bg-purple-dark {
    background: #99a9bf;
  }

  .bg-purple {
    background: #d3dce6;
  }

  .bg-purple-light {
    background: #e5e9f2;
  }

  .grid-content {
    border-radius: 4px;
    min-height: 36px;
  }

  .row-bg {
    padding: 10px 0;
    background-color: #f9fafc;
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
