<template>
  <div>
    <h1>Weather forecast</h1>

    <p>This component demonstrates fetching data from a service.</p>

    <p v-if="loading == true"><em>Loading...</em></p>

    <table class="table" v-if="movies != null">
      <thead>
        <tr>
          <th>Name</th>
          <th>Description</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="movie in movies" v-bind:key="movie.id">
          <td>{{movie.name}}</td>
          <td>{{movie.description}}</td>
        </tr>
      </tbody>
    </table>

    <p>Length: {{movies.length}}</p>
  </div>
</template>

<script>
import { Component, Prop, Vue } from 'vue-property-decorator'
import { mapState, mapActions } from 'vuex'

export default {
  props: ['loading'],
  // ...
  computed: mapState({
    // arrow functions can make the code very succinct!
    movies: state => state.movies.list
  }),
  methods: mapActions('movies', [
    'fetchMovies'
  ]),
  created () {
    this.$store.dispatch('movies/fetchMovies')
  }
}

</script>
