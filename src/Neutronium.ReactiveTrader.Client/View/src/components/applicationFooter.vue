<<template>
    <v-footer :fixed="fixed" app>
    &copy; {{year}}
    <v-spacer></v-spacer>
    <p v-if="connectivity">
    <span>ConnType:</span>{{connectivity.TransportName}}&emsp;
    <span>E2E Lat.:</span>{{connectivity.TotalLatency}}&emsp;
    <span>UI Upd.:</span>{{connectivity.UiUpdates}}/sec&emsp;
    <span>Server Upd.:</span>{{connectivity.TicksReceived}}/sec&emsp;
    <span>CPU:</span>{{connectivity.CpuPercent}}%&emsp;
    <span>UI Lat.:</span>{{connectivity.UiLatency}}ms&emsp;
    </p>
    </v-footer>
</template>

<script>
const props = {
  fixed: {
    type: Boolean,
    default: false
  },
  year: {
    type: Number,
    required: false
  },
  connectivity: {
    required: true
  }
};

export default {
  props
};
</script>

<style scoped>
span {
  color: grey;
}
</style>

