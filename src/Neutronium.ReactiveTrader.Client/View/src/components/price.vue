<template>
    <div class="price">
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

</style>
