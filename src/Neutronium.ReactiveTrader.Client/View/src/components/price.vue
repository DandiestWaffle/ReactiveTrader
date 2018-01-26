<template>
  <v-container grid-list-md text-xs-center class="price">
      <v-layout row wrap>
        <v-flex xs12>
          <flat-button color="primary" :text="price.Direction.displayName" :command="price.ExecuteCommand"></flat-button>
        </v-flex>
      <v-flex xs12>
        <span>
          <span>{{price.BigFigures}}</span>
          <em class="price">{{price.Pips}}</em>
          <span>{{price.TenthOfPip}}</span>
        </span>
      </v-flex>
    </v-layout>
  </v-container>
</template>
<script>
import flatButton from "./flatButton";

const props = {
  price: {
    required: true,
    type: Object
  }
};
export default {
  components: {
    flatButton
  },
  props
};
</script>
<style scoped>
.price em{
  font-size:1.5em;
}
</style>
