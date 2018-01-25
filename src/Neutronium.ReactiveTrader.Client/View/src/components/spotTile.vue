<template>
    <v-card class="spot">
        {{spotTile.CurrencyPair}}
    </v-card>
</template>
<script>
const props = {
  spotTile: {
    required: true,
    type: Object
  }
};
export default {
  props
}
</script>
<style scoped>
.spot{
    min-height: 50px;
}
</style>
