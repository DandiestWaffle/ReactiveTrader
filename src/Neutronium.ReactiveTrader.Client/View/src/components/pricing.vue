<template>
  <v-card :class="{error: isError}">
    <v-card-title primary class="title title-pricing">
      {{pricing.Symbol}}
      <v-spacer></v-spacer>
      <v-progress-circular v-show="isExecuting" indeterminate :size="30" :width="7" color="purple"></v-progress-circular>
    </v-card-title>
    <v-card-text>
      <v-layout row wrap v-if="isError">
        <h4 class="orange--text">Pricing currently unavailable</h4>
      </v-layout>
      <div v-else>
        {{pricing.Notional}} {{pricing.DealtCurrency}} - {{pricing.SpotDate}}
        <v-layout row wrap>    
          <v-flex md5>
            <price :price="pricing.Bid"></price>
          </v-flex>
          <v-flex md2>
            <v-icon large color="green darken-2"  v-show="isUp">fa-chevron-up</v-icon>
            {{pricing.Spread}}
            <v-icon large color="red darken-2"  v-show="isDown">fa-chevron-down</v-icon>
          </v-flex>
          <v-flex md5>
            <price :price="pricing.Ask"></price>
          </v-flex>
        </v-layout>
      </div>
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
  computed: {
    isExecuting() {
      return this.pricing.Bid.IsExecuting || this.pricing.Ask.IsExecuting;
    },
    isUp() {
      return this.pricing.Movement.displayName === "Up";
    },
    isDown() {
      return this.pricing.Movement.displayName === "Down";
    },
    isError() {
      return this.pricing.IsStale;
    }
  },
  props
};
</script>
<style scoped>
.title-pricing {
  height: 45px;
}
.error {
  background: red;
}
</style>
