<template>
  <div>
    <p class="title"> 会员充值 </p>
    <div class="content">
      <p>
        目前本网内容只对会员开放。 会员充值方式步骤如下：
        <br/> 1、
        <span style="color:red">青铜</span>
        <br/> 期限：半年
        <br/> 权限：期限内全站所有版块无限下载、免回复、免广告
        <br/> 价格：115元
        <br/> 2、
        <span style="color:red">白银</span>
        <br/> 期限：一年
        <br/> 权限：期限内全站所有版块无限下载、免回复、免广告
        <br/> 价格：215元
        <br/> 3、
        <span style="color:red">黄金</span>
        <br/> 期限：永久
        <br/> 权限：永久全站所有版块无限下载、免回复、免广告
        <br/> 价格：415元
        <br/>
      </p>
    </div>
  </div>
</template>

<style>
  div .title {
    text-align: left;
    font-size: 21px;
    font-weight: bold;
    line-height: 1.5;
    padding: 7px 25px;
    background-color: green;
    color: #fff;
    border: 1px solid #09a800;
  }

  div .content {
    text-align: left;
    border: 1px solid #d0d3d0;
  }

</style>


<script>
  export default {
    name: "MemberLink"
  };

</script>
