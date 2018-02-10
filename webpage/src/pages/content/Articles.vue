<template> 
<div id="test"> 
  <ul>
    <li  v-for="(item,index) in items" :key="index">
      {{item}}
    </li>
  </ul>
</div>
</template>
<script>

export default {
  name: "ContentArticles", 
  // el: "#test",
  // data: {
  // return  items: []
  // },
  // methods() {
  //   Vue.axios
  //     .get(
  //       "https://free-api.heweather.com/s6/weather/now?location=CN101010100&key=227e8c46911e473ea5b00590643b1299"
  //     )
  //     .then(response => {
  //       // this.items= response.data.results
  //       console.log(response);
  //     });
  // }
};
</script>
