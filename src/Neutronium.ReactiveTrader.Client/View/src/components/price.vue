<template>
    <div class="price">
        {{price.Direction.displayName}}
    </div>
</template>
<script>
const props = {
  price: {
    required: true,
    type: Object
  }
};
export default {
  props
}
</script>
<style scoped>
</style>
