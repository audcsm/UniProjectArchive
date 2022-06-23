<template>
  <v-container class="fill-height" fluid>
    <v-row align="center" justify="center">
      <v-col cols="12" sm="8" md="4">
        <v-card class="elevation-12">
          <v-toolbar dark flat >
            <v-toolbar-title>Current Items</v-toolbar-title>
            <div class="flex-grow-1"></div>
            <v-tooltip bottom>
            </v-tooltip>
          </v-toolbar>
          <v-card-text>
            <ul v-for="post in posts" v-bind:key="post.id">
                <li> User ID: {{ post.user_id }} | Keywords: {{ post.keywords }} | Description: {{ post.description }} | Lat: {{ post.lat }} | Lon: {{ post.lon }} | Image URL: </li>
            </ul>
          </v-card-text>
          <v-card-actions>
            <v-btn color="secondary" @click="redirectHome()">Create Item</v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
export default {
  data () {
    return {
      posts: []
    }
  },
  methods: {
    async getData () {
      try {
        // eslint-disable-next-line prefer-const
        let response = await fetch('https://8000-copper-slug-6fjpzrxa.ws-us27.gitpod.io/item')
        this.posts = await response.json()
      } catch (error) {
        console.log(error)
      }
    },
    // redirect to the create item page
    redirectHome () {
      this.$router.push('/')
    }
  },
  created () {
    this.getData()
  }
}
</script>
