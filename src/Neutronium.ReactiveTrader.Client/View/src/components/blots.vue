<template>
    <v-data-table item-key="TradeId" :headers="headers" :items="blots" hide-actions class="elevation-1">
        <template slot="items" slot-scope="props">
            <td>{{ props.item.TradeDate | moment("MMMM Do YYYY HH:mm:ss")}}</td>
            <td class="text-xs-center">{{ props.item.Direction.displayName }}</td>
            <td class="text-xs-center">{{ props.item.CurrencyPair }}</td>
            <td class="text-xs-center">{{ props.item.Notional }}</td>
            <td class="text-xs-center">{{ props.item.SpotRate }}</td>
            <td class="text-xs-center">{{ props.item.TradeStatus }}</td>
            <td class="text-xs-center">{{ props.item.ValueDate | moment("DD MMM YY")}}</td>
            <td class="text-xs-center">{{ props.item.TraderName }}</td>
            <td class="text-xs-center">{{ props.item.TradeId }}</td>
        </template>
        <template slot="no-data">
            <v-alert :value="true" color="warning" icon="warning">
                No data.
            </v-alert>
        </template>
    </v-data-table>

</template>
<script>
const props = {
  blots: {
    required: true,
    type: Array
  }
};

export default {
  props,
  data() {
    return {
      headers: [
        {
          text: "Date",
          align: "center",
          sortable: true,
          value: "TradeDate"
        },
        {
          text: "Dir.",
          align: "center",
          sortable: true,
          value: "Direction"
        },
        {
          text: "CCY",
          align: "center",
          sortable: true,
          value: "CurrencyPair"
        },
        {
          text: "Notional",
          align: "center",
          sortable: true,
          value: "Notional"
        },
        {
          text: "Rate",
          align: "center",
          sortable: true,
          value: "SpotRate"
        },
        {
          text: "Status",
          align: "center",
          sortable: true,
          value: "TradeStatus"
        },
        {
          text: "Value Date",
          align: "center",
          sortable: true,
          value: "ValueDate"
        },
        {
          text: "Trader",
          align: "center",
          sortable: true,
          value: "TraderName"
        },
        {
          text: "Trade #",
          align: "center",
          sortable: true,
          value: "TradeId"
        }
      ]
    };
  }
};
</script>
<style>

</style>
