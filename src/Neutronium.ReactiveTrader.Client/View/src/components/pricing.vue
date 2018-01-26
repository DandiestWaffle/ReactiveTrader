<template>

  <v-card class="pricing">
    <v-card-title primary class="title">{{pricing.Symbol}}</v-card-title>
    <v-card-text>
      <v-layout row wrap>
        <v-flex xs6>
          <price :price="pricing.Bid"></price>
        </v-flex>
        <v-flex xs6>
          <price :price="pricing.Ask"></price>
        </v-flex>
      </v-layout>

    </v-card-text>
  </v-card>
</template>
<script>
import price from "./price";

const props = {
  pricing: {
    required: true,
    type: Object
  }
};
export default {
  components: {
    price
  },
  props
};
</script>
<style scoped>

</style>
