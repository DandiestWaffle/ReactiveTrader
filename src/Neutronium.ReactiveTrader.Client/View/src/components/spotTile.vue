<template>
  <div class="spot">
    <affirmation class="item" v-if="spotTile.Affirmation" :affirmation="spotTile.Affirmation" :height="height">
    </affirmation>
    <pricing class="item" v-else-if="spotTile.Pricing" :pricing="spotTile.Pricing" :height="height">
    </pricing>
    <configuration class="item" v-else-if="spotTile.Config" :configuration="spotTile.Config" :height="height">
    </configuration>
  </div>
</template>
<script>
import affirmation from "./affirmation";
import pricing from "./pricing";
import configuration from "./configuration";

const props = {
  spotTile: {
    required: true,
    type: Object
  },
  height: {
    required: false,
    default: "220px"
  }
};
export default {
  components: {
    pricing,
    configuration,
    affirmation
  },
  props
};
</script>
<style scoped>

</style>
