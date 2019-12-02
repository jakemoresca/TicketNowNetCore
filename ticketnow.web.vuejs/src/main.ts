import Vue from 'vue'
import Vuex from 'vuex'
import App from './App.vue'
import router from './router'
import { store } from './store'
import 'bootstrap'
import 'bootstrap/scss/bootstrap.scss'
import './assets/site.css'
import 'open-iconic/font/css/open-iconic-bootstrap.scss'

Vue.config.productionTip = false

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')
