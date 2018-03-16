<template> 
<div id="test"> 
  <ul>
     <el-button type="primary" @click="testClick"></el-button>
    <!-- <li  v-for="(item,index) in items" :key="index"> -->
      {{items}}
    <!-- </li> -->
  </ul>
</div>
</template>
<script>
import axios from "axios";
export default {
  name: "ContentArticles",
  data() {
    return {
      items: ""
    };
  },
  methods: {
    testClick(evt) {
      let _self = this;
      axios
        .get("http://localhost:55636/api/values")
        .then(function(response) {
          console.log(response);
          _self.items = response.data;
        })
        .catch(function(error) {
          console.log(error);
        });
    }
  }
};

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
</script>
