<template>
    <main>
        <v-content>
            <v-container fluid class="main-container">

                <v-layout>
                    <v-flex md10 offset-md1>
                        <blots :blots="viewModel.Blotter.Trades">
                        </blots>
                    </v-flex>
                </v-layout>

            </v-container>
        </v-content>
    </main>
</template>

<script>
import blots from "../components/blots";

const props = {
  viewModel: Object
};

export default {
  components: {
    blots
  },
  props
};
</script>

<style>
main {
  height: calc(100% - 50px);
}

.main-container {
  height: 100%;
  overflow-y: auto;
}
</style>