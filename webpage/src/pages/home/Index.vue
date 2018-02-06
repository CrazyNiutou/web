<template>
  <p>124234</p>
</template>
<script>
export default {
  name: "HomeIndex"
};

axios.get('/user?ID=1234')
.then(function(respone){
  console.log(response);
})
.catch(function(error){
  console.log(error);
});


</script>
