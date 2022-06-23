import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import vuetify from './plugins/vuetify'
// import axios from 'axios'

Vue.config.productionTip = false

new Vue({
  router,
  store,
  vuetify,
  render: h => h(App)
}).$mount('#app')

/* axios.post('http://localhost:8000/item', {
  params: {
    user_id: this.user_id,
    keywords: this.keywords,
    desc: this.desc,
    imgurl: this.imgurl,
    lat: this.lat,
    lon: this.lon
  }
}) */
