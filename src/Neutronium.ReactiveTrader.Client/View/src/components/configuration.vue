<template>
  <v-layout row wrap>
    <v-flex xs6>
      <v-card>
        <v-card-title primary class="title">Price Rendering</v-card-title>
        <v-card-actions>
          <flat-button text="Standard" :command="configuration.StandardCommand"></flat-button>
          <flat-button text="Drop Frame" :command="configuration.DropFrameCommand"></flat-button>
          <flat-button text="Conflate" :command="configuration.ConflateCommand"></flat-button>
          <flat-button text="ConstantRate" :command="configuration.ConstantRateCommand"></flat-button>
        </v-card-actions>
      </v-card>
    </v-flex>
    <v-flex xs6>
      <v-card>
        <v-card-title primary class="title">Trade Execution</v-card-title>
        <v-card-actions>
          <flat-button text="Asynchronous" :command="configuration.AsyncCommand"></flat-button>
          <flat-button text="Synchronous" :command="configuration.SyncCommand"></flat-button>
        </v-card-actions>
      </v-card>
    </v-flex>
  </v-layout>
</template>
<script>
import flatButton from "./flatButton";


const props = {
  configuration: {
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
