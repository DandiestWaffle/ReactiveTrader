<template>
  <v-card class="pricing-card" :height="height">
    <v-card-title primary class="title title-pricing">
      <span>{{affirmation.CurrencyPair}}</span>
      <span class="text-xs-right">{{affirmation.Rejected}}</span>
    </v-card-title>
    <v-card-text class="card-affirmation">  
      <v-container fluid grid-list-md class="last-row">
        <v-layout row wrap md12 text-xs-center>
          <v-flex md7 text-xs-left>
             <p>Sold <em>{{affirmation.DealtCurrency}} {{affirmation.Notional}}</em></p>
              <p>vs <em>{{affirmation.OtherCurrency}}</em> at <em>{{affirmation.SpotRate}}</em></p>
              <p>Spot <em>{{affirmation.TradeDate  | moment("D MMM YYYY") }}</em></p>
            <p>Trade ID <em>{{affirmation.TradeId}}</em></p>
          </v-flex>
          <v-flex md5>
            <text-button text="Done" :command="affirmation.DismissCommand"></text-button>
          </v-flex>
        </v-layout>
      </v-container>
    </v-card-text>
  </v-card>
</template>
<script>
import textButton from "./textButton";

const props = {
  affirmation: {
    required: true,
    type: Object
  },
  height: {
    required: false,
    default: "auto"
  }
};
export default {
  components: {
    textButton
  },
  props
};
</script>
<style scoped>
.card-affirmation {
  padding-top: 8px;
}
em {
  color: orange;
}
.last-row {
  text-align: center;
}
p:last-child {
  margin-bottom: 5px;
}
</style>
