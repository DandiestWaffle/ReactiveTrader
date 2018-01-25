<template>
    <main>
      <v-content>
        <v-container fluid>

        <v-layout>
          <v-flex xs12 sm6 offset-sm3>
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
import iconButton from '../components/IconButton'
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
</style>




