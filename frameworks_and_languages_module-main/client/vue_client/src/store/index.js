/* import axios from 'axios'
import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    // hold the recently added item and token
    // status shows if the item succeeded or failed parameters
    item: {},
    token: localStorage.getItem('token') || '',
    status: null
  },
  mutations: {
    // mutation for the loading status
    loadingMutation (state) {
      state.status = 'loading'
    },
    // mutation for token being successfully authorised
    itemSuccessfulMutation (state, token, item) {
      state.status = 'success'
      state.token = token
      state.item = item
    },
    // mutation for incorrectly entered parameters
    itemFailedMutation (state) {
      state.status = 'failure'
      state.token = ''
      state.item = {}
    }
  },
  actions: {
    // fetch a response from the API and update the status based on mutation
    saveAction ({ commit }, itemDetails) {
      commit('loadingMutation')
      return new Promise((resolve, reject) => {
        axios.post('http://localhost:8001', itemDetails)
          .then(response => {
            // item passed parameters, state successful, save to Vuex
            const token = response.data.auth_token
            const item = response.data.item
            commit('itemSuccessfulMutation', { token, item })
            localStorage.setItem('token', token)
            // send update to axios
            axios.defaults.headers.common.authorization = token
            window.alert('passed')
            resolve(response)
          })
          .catch(error => {
            // item failed parameters, state failed, remove the token
            commit('itemFailedMutation')
            localStorage.removeItem('token')
            window.alert('failed')
            reject(error)
          })
      })
    }
  },
  modules: {
  }
}) */
