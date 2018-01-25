<template>
    <div>
        <spot-tile v-for="(spot,index) in spotTiles" :spotTile="spot" :key="index">
        </spot-tile>
    </div>
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
