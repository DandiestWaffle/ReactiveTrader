<template>
    <div class="price">
        <span>
            <span>{{price.BigFigures}}</span>
            <em class="price">{{price.Pips}}</em>
            <span>{{price.TenthOfPip}}</span>
        </span>
        <flat-button color="primary" :text="price.Direction.displayName" :command="price.ExecuteCommand"></flat-button>
    </div>
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
  font-size:3em;
}
</style>
