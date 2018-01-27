<template>
  <v-card>
    <v-card-title class="title orange--text">{{title}}</v-card-title>
    <v-card-text class="card-configuration">
      <v-btn-toggle mandatory v-model="choosen">
        <v-tooltip bottom v-for="(cmd, index) in commands" :key="index">
          <v-btn flat slot="activator" @click.native="choosen=index">
            <v-icon>{{cmd.icon}}</v-icon>
          </v-btn>
          <span>{{cmd.comment}}</span>
        </v-tooltip> 
      </v-btn-toggle>
    </v-card-text>
  </v-card>
</template>
<script>
function execute(cmd) {
  cmd.Execute();
}

const props = {
  commands: {
    required: true,
    type: Array
  },
  title: {
    required: true,
    type: String
  }
};

export default {
  watch: {
    choosen(newValue) {
      const cmd = this.commands[newValue];
      execute(cmd.command);
    }
  },
  data() {
    return {
      choosen: 0
    };
  },
  props
};
</script>
<style scoped>
.card-configuration {
  padding-top: 0px;
}
</style>
