<template>
<div id="tet"> 
  <ul>
    <li  v-for="(item,index) in items" :key="index">
      {{item.message}}
    </li>
  </ul>
</div>
</template>
<script>
import Vue from "vue";
export default {
  name: "ContentArticles"
}; 
var temp = new Vue({
  el: "#tet",
  data: {
    items: []
  },
  mounted() {
    axios.get("https://free-api.heweather.com/s6/weather/now?location=CN101010100&key=227e8c46911e473ea5b00590643b1299")
    .then(response=>{this.items= response.data.results })
  }
});
</script>
