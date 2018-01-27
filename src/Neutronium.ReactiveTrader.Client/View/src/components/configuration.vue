<template>
  <v-layout md12 column justify-space-between class="configuration-main" :style="{'height':height}">
    <v-flex md12 class="container up">
      <basic-configuration class="item" title="Price Rendering" :commands="renderingCommands">
      </basic-configuration>
    </v-flex>
    <v-flex md12 class="container down">
      <basic-configuration class="item" title="Trade Execution" :commands="tradeExecutionCommands">
      </basic-configuration>
    </v-flex>
  </v-layout>
</template>
<script>
import basicConfiguration from "./basicConfiguration";
import flatButton from "./flatButton";
import iconButton from "./iconButton";

function execute(cmd) {
  if (cmd.CanExecuteValue) {
    cmd.Execute();
  }
}

const props = {
  configuration: {
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
    flatButton,
    iconButton,
    basicConfiguration
  },
  watch: {
    rendering(newValue) {
      console.log(newValue);
      const cmd = this.renderingCommands[newValue];
      execute(cmd);
    }
  },
  data() {
    return {
      rendering: 0
    };
  },
  computed: {
    renderingCommands() {
      const configuration = this.configuration;
      return [
        {
          command: configuration.StandardCommand,
          icon: "library_books",
          comment: "Standard"
        },
        {
          command: configuration.DropFrameCommand,
          icon: "whatshot",
          comment: "Drop Flame"
        },
        {
          command: configuration.ConflateCommand,
          icon: "call_merge",
          comment: "Conflate"
        },
        {
          command: configuration.ConstantRateCommand,
          icon: "trending_flat",
          comment: "ConstantRate"
        }
      ];
    },
    tradeExecutionCommands() {
      const configuration = this.configuration;
      return [
        {
          command: configuration.AsyncCommand,
          icon: "sync",
          comment: "Asynchroneous"
        },
        {
          command: configuration.SyncCommand,
          icon: "arrow_forward",
          comment: "Synchroneous"
        }
      ];
    }
  },
  props
};
</script>
<style scoped>
.configuration-main{
  margin: 0px !important;
}
.container {
  display: flex;
  flex-direction: column;
  padding: 0px !important;
}
.container.up {
  justify-content: flex-start;
}
.container.down {
  justify-content: flex-end;
}
.container.down>.item{
  padding-bottom: 0px;
}
</style>
