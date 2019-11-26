<template>
  <div id="app" class="row">
    <NavMenu />

    <div class="main">
      <div class="top-row px-4">
        <a href="https://docs.microsoft.com/en-us/aspnet/" target="_blank">About</a>
      </div>

      <div class="content px-4">
        <router-view />
      </div>
    </div>
  </div>
</template>

<script>// @ is an alias to /src
import NavMenu from '@/components/NavMenu.vue'

export default {
  name: 'app',
  components: {
    NavMenu
  }
}</script>
