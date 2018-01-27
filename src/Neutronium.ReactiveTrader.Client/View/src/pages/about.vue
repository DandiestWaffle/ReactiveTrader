<template>
    <main>
        <v-content>
            <v-flex xs12 sm6 offset-sm3>
            <v-card>
                <v-card-title primary-title>
                <div>
                    <h3 class="headline mb-0 blue--text">{{viewModel.Information.Name}}</h3>
                </div>
                </v-card-title>
                <v-card-actions>
                    <v-btn flat color="orange" href="https://github.com/AdaptiveConsulting/ReactiveTrader/" target="_blank">Reactive Trader</v-btn>
                    <v-btn flat color="orange" href="https://github.com/NeutroniumCore/Neutronium/" target="_blank">Neutronium</v-btn>
                </v-card-actions>
            </v-card>
            </v-flex>
        </v-content>
    </main>
</template>

<script>
const props = {
  viewModel: Object
};

export default {
  props
};
</script>

<style>

</style>
