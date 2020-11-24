<template>
    <v-container>
        <v-data-table
            :hearders="headers"
            :items="pessoas"
        >
            <template slot="no-data">
                <span>Nenhum pessoa retornada</span>
            </template>
        </v-data-table>
    </v-container>
</template>

<script lang="ts">
import Vue from 'vue';
import { pessoaAPI } from './API/PessoaAPI';

export default Vue.extend({
  data() {
    return {
      headers: [
        {
          text: 'Nome',
          value: 'nome',
        },
        {
          text: 'Email',
          value: 'email',
        },
      ],
      pessoas: [],
    };
  },
  methods: {
    listarPessoas() {
      pessoaAPI.list()
        .then((resp) => {
          this.pessoas = resp.data;
        })
        .catch((error) => {
          console.log(error);
        });
    },
  },
  mounted() {
    this.listarPessoas();
  },
});
</script>
