<template>
  <v-card class="pricing-error" :height="height" color="red">
    <v-card-title primary class="error-title">
      ERROR
    </v-card-title>
    <v-card-text class="card-error">
      {{error.ErrorMessage}}
    </v-card-text>
    <v-card-actions>
      <v-spacer></v-spacer>
      <text-button text="Done" :command="error.DismissCommand"></text-button>
    </v-card-actions>
  </v-card>
</template>
<script>
import textButton from "./textButton";

const props = {
  error: {
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
.card-error {
  padding-top: 0px;
}
.error-title {
  padding-bottom: 2px;
  padding-top: 6px;
}
.pricing-error > .error-title {
  font-size: 19px;
}
</style>
