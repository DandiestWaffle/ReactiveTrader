<template>
  <v-card class="pricing-card" :height="height">
    <v-card-title primary class="title title-pricing">
      <span>{{affirmation.CurrencyPair}}</span>
      <v-spacer></v-spacer>
      <span class="red--text text-xs-right">{{affirmation.Rejected}}</span>
    </v-card-title>
    <v-card-text class="card-affirmation">
      <p>Sold <em>{{affirmation.DealtCurrency}} {{affirmation.Notional}}</em></p>
      <p>vs <em>{{affirmation.OtherCurrency}}</em> at <em>{{affirmation.SpotRate}}</em></p>
      <p>Spot <em>{{affirmation.TradeDate  | moment("D MMM YYYY") }}</em></p>
      <p>Trade ID <em>{{affirmation.TradeId}}</em></p>
    </v-card-text>
    <v-card-actions>
    <v-spacer></v-spacer><text-button text="Done" :command="affirmation.DismissCommand"></text-button>
    </v-card-actions>
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
  padding-top: 4px;
  padding-bottom: 0px;
  font-size: 15px;
}
em {
  color: orange;
}
.last-row {
  text-align: center;
}
p:last-child {
  margin-bottom: 4px;
}
p{
  margin-bottom: 4px;
}
</style>
