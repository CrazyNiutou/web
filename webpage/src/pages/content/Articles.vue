<template> 
<div id="test"> 
  <ul>
    <li v-for="item in items" :key="item.id">
      {{item}} 
    </li> 
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
  created(){
    this.testClick();
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
</script>
