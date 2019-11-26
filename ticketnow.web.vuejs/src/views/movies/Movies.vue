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
        <tr v-for="movie in movies" v-bind:key="movie.Id">
          <td>{{movie.Name}}</td>
          <td>{{movie.Description}}</td>
        </tr>
      </tbody>
    </table>

    <p>Length: {{movies.Length}}</p>
  </div>
</template>

<script>
import { Component, Prop, Vue } from 'vue-property-decorator'
import { mapState } from 'vuex'

export default {
  props: ['loading'],
  // ...
  computed: mapState({
    // arrow functions can make the code very succinct!
    movies: state => state.movie.movies
  })
}

</script>
