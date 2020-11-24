<template>
    <v-container id = "login">
        <v-form @submit="login">
            <v-row>
                <v-col cols="4">
                    <v-p> Login </v-p>
                    <v-text-field v-model="payload.Login">

                    </v-text-field>
                </v-col>
            </v-row>

            <v-row>
                <v-col cols="4">
                    <v-p> Password </v-p>
                    <v-text-field v-model="payload.Password">

                    </v-text-field>
                </v-col>
            </v-row>

            <v-row>
                <v-col cols="4">
                    <v-btn>
                        Logar
                    </v-btn>
                </v-col>
            </v-row>
        </v-form>
    </v-container>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  data() {
    return {
      payload: {},
    };
  },
  methods: {
    ...mapActions([
      'setUser',
    ]),
    login() {
      if (this.payload.Login === '123' && this.payload.Password === '123') {
        this.setUser(this.payload);
        console.log('Logou!');
      }
    },
  },
};
</script>

<style scoped>

</style>
