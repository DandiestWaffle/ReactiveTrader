<template>
    <v-container grid-list-md>
      <v-layout row wrap>
        <v-flex xl2 lg3 md4 sm6 xm12 v-for="(spot,index) in spotTiles" :key="index">
          <spot-tile  :spotTile="spot" >
          </spot-tile>
        </v-flex>
      </v-layout>
  </v-container>
</template>
<script>
import spotTile from "./spotTile";

const props = {
  spotTiles: {
    required: true,
    type: Array
  }
};
export default {
  components: {
    spotTile
  },
  props
};
</script>
<style scoped>

</style>
