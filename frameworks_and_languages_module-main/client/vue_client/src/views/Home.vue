<template>
  <v-container class="fill-height" fluid>
    <v-row align="center" justify="center">
      <v-col cols="12" sm="8" md="4">
        <v-card class="elevation-12">
          <v-toolbar dark flat >
            <v-toolbar-title>Create a New Item</v-toolbar-title>
            <div class="flex-grow-1"></div>
            <v-tooltip bottom>
            </v-tooltip>
          </v-toolbar>
          <v-card-text>
            <v-form>
              <v-text-field label="User ID" name="user_id" type="text" v-model="user_id"></v-text-field>
              <v-text-field label="Keyword" name="keywords" type="text" v-model="keywords"></v-text-field>
              <v-text-field label="Description" name="desc" type="text" v-model="desc"></v-text-field>
              <v-text-field label="Image URL" name="imgurl" type="text" v-model="imgurl"></v-text-field>
              <v-text-field label="Latitude" name="lat" type="number" v-model="lat"></v-text-field>
              <v-text-field label="Longitude" name="lon" type="number" v-model="lon"></v-text-field>
            </v-form>
          </v-card-text>
          <v-card-actions>
            <div class="flex-grow-1"></div>
            <v-btn color="secondary" @click="redirectList()" >View Items</v-btn>
            <v-btn color="primary" @click="postData(); resetForm()" >Submit</v-btn>
            <v-btn color="error" @click="resetForm()" class="reset"> Reset Form </v-btn>
          </v-card-actions>
        </v-card>
      </v-col>
    </v-row>
  </v-container>
</template>

<script>
import axios from 'axios'
export default {
  // export data from the form, notice each item has a corresponding label
  data () {
    return {
      user_id: '',
      keywords: '',
      desc: '',
      imgurl: '',
      lat: '',
      lon: ''
    }
  },
  methods: {
    // resets the form for accessibility purposes
    resetForm () {
      this.user_id = ''
      this.keywords = ''
      this.desc = ''
      this.imgurl = ''
      this.lat = ''
      this.lon = ''
    },
    postData () {
      axios.post('https://8000-copper-slug-6fjpzrxa.ws-us27.gitpod.io/item', {
        user_id: this.user_id,
        keywords: this.keywords,
        description: this.desc,
        lat: this.lat,
        lon: this.lon
      })
        .then(function (response) {
          console.log(response)
        })
        .catch(function (error) {
          console.log(error)
        })
    },
    redirectList () {
      this.$router.push('/list')
    }
  }
}
</script>
