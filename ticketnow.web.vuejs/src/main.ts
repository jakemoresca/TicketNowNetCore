import Vue from 'vue'
import Vuex from 'vuex'
import App from './App.vue'
import router from './router'
import 'bootstrap'
import 'bootstrap/scss/bootstrap.scss'
import './assets/site.css'
import 'open-iconic/font/css/open-iconic-bootstrap.scss'

Vue.config.productionTip = false
Vue.use(Vuex)

const store = new Vuex.Store({
  state: {
    movie: {
      movies: [{
        Id: 'test',
        Name: 'test',
        Description: 'test'
      }]
    }
  }
})

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
