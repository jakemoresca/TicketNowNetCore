<template>
  <div id="nav" class="sidebar">
    <div class="top-row pl-4 navbar navbar-dark">
      <a class="navbar-brand" href="">TicketNow.Web</a>
      <button class="navbar-toggler">
        <span class="navbar-toggler-icon"></span>
      </button>
    </div>

    <div class="collapse">
      <ul class="nav flex-column">
        <li class="nav-item px-3">
          <router-link class="nav-link" to="/">
            <span class="oi oi-home" aria-hidden="true"></span> Home
          </router-link> |
        </li>
        <li class="nav-item px-3">
          <router-link class="nav-link" to="/about">
            <span class="oi oi-plus" aria-hidden="true"></span> About
          </router-link>
        </li>
        <li class="nav-item px-3">
          <router-link class="nav-link" to="/movies">
            <span class="oi oi-plus" aria-hidden="true"></span> Movies
          </router-link>
        </li>
      </ul>
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator'

@Component
export default class NavMenu extends Vue {
}
</script>
