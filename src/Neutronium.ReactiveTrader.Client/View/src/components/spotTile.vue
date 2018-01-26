<template>
  <v-card class="spot">
    <pricing v-if="spotTile.Pricing" :pricing="spotTile.Pricing">
    </pricing>
    <configuration v-else-if="spotTile.Config" :configuration="spotTile.Config">
    </configuration>

  </v-card>
</template>
<script>
import pricing from "./pricing";
import configuration from "./configuration";

const props = {
  spotTile: {
    required: true,
    type: Object
  }
};
export default {
  components: {
    pricing,
    configuration
  },
  props
};
</script>
<style scoped>
.spot {
  min-height: 50px;
}
</style>
