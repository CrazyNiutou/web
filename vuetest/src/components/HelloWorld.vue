<template>
  <div class="hello">
    <h1>{{ msg }}</h1>
    <h1>{{ test }}</h1>
    <p>rawHtml: {{ rawHtml }}</p>
    <p>rawHtml:
      <span v-html="rawHtml"></span>
    </p>
    <div v-bind:id="dynamicId"></div>
    <p v-if="seen">现在你看到我了</p>

    <div id="example">
      <p>Original message: "{{ message }}"</p>
      <p>Computed reversed message: "{{ reversedMessage }}"</p>
    </div>

  </div>
</template>

<script>
  var data = {
    msg: '111'
  }
  export default {
    name: 'HelloWorld',
    data() {
      return {
        ...data,
        test: 'v-once',
        rawHtml: '<span style="color:red">rawHtml</span>',
        dynamicId: 'test',
        seen: true,
        message: 'Hello'
      }
    },
    computed: {
      reversedMessage: function () {
        return this.message.split('').reverse().join('')
      }
    },
    created: function () {
      console.log(data.msg + this.msg)
    }
  }

</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
  h1,
  h2 {
    font-weight: normal;
  }

  ul {
    list-style-type: none;
    padding: 0;
  }

  li {
    display: inline-block;
    margin: 0 10px;
  }

  a {
    color: #42b983;
  }

</style>
