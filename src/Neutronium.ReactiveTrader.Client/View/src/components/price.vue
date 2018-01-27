<template>
  <v-container grid-list-md text-xs-center class="price">
        <flat-button color="primary" :text="price.Direction.displayName" :command="price.ExecuteCommand"></flat-button>
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
  font-size:2.2em;
}
</style>
