import axios from 'axios'

const state =
{
  list: []
}

const mutations =
{
  setMovies (state: any, movies: any) {
    state.list = movies
  }
}

const actions =
{
  async fetchMovies (context: any) {
    const movies = await axios.get('https://localhost:5001/movies')

    context.commit('setMovies', movies.data)
  }
}

export default {
  namespaced: true,
  state,
  actions,
  mutations
}
