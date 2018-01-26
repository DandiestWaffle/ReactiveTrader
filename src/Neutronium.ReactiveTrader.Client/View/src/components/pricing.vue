<template>
  <v-card :class="{error: isError}" class="pricing-card">
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
        <v-layout row wrap>
          <v-flex md5>
            <price :price="pricing.Bid"></price>
          </v-flex>
          <v-flex md2 class="text-xs-center">
            <div class="for-icon">
              <v-icon large color="green darken-2" v-show="isUp">fa-chevron-up</v-icon>
            </div>
            <p>{{pricing.Spread}}</p>
            <div class="for-icon">
              <v-icon large color="red darken-2" v-show="isDown">fa-chevron-down</v-icon>
            </div>
          </v-flex>
          <v-flex md5>
            <price :price="pricing.Ask"></price>
          </v-flex>
        </v-layout>
        <v-container grid-list-md text-xs-center>
          <v-layout row wrap>
            <v-flex class="text-md-left" md2>
               {{pricing.DealtCurrency}}
            </v-flex>
            <v-flex class="text-md-left" md5>
                <input class="notional" type="text" v-model="pricing.Notional"></input>
            </v-flex>
            <v-flex class="text-md-right" md5>
              {{pricing.SpotDate}}
            </v-flex>
          </v-layout>
        </v-container>
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
input.notional{
  outline: 0px;
}
input:focus.notional{
  color:rgb(56, 142, 60);
}
.title-pricing {
  height: 45px;
}
.error {
  background: red;
}
.for-icon{
  height: 20px;
}
:hover.pricing-card{
  background: black;
}
</style>
