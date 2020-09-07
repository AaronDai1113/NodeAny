<template>
  <div class="hello">
    <input type="text" @keyup.enter="addFeature">
    <div v-for="feature in features" :key="feature">
      {{ feature }}
    </div>
    <div>new feature num:{{count}}</div>
  </div>
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component'

@Options({
  props: {
    msg: String
  }
})
export default class HelloWorld extends Vue {
  features: string[]=['type marks','type check'];
  addFeature(e:any){
    this.features.push(e.target.value);
    e.target.value='';
  }
  get count(){
    return this.features.length
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
h3 {
  margin: 40px 0 0;
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
