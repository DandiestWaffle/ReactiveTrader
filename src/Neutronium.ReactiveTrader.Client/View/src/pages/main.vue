<template>
    <main>
      <v-content>
        <v-container fluid class="main-container">

          <v-layout>
            <v-flex>
                <spot-tiles :spotTiles="viewModel.SpotTiles.SpotTiles">
                </spot-tiles>
            </v-flex>
          </v-layout>

        </v-container>
      </v-content>
    </main>
</template>

<script>
import textButton from '../components/textButton'
import iconButton from '../components/iconButton'
import spotTiles  from '../components/spotTiles'

const props={
  viewModel: Object,
}

export default {
  components:{
    textButton,
    iconButton,
    spotTiles
  },
  methods:{
    enter(){
      const command = this.viewModel.AddItem;
      if (command)
        command.Execute()
    }
  },
  props
}
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




