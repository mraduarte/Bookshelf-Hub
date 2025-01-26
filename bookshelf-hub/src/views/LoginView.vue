<template>
  <div class="home">
    <div class="col-2 mx-auto mt-5">
      <h2>{{ $t('common.welcome') }}</h2>
    </div>

    <div class="col-3 custom-margin">
      <label class="d-block text-left">{{ $t('common.email') }}</label>
      <InputText type="email"></InputText>

      <label class="d-block text-left">{{ $t('common.password') }}</label>
      <InputText type="password"></InputText>

      <p>{{ $t('common.forgotPassword') }}</p>

      <ButtonComponent type="submit" value="submit" :text="$t('common.login')"></ButtonComponent>
      
      <p class="mt-4">
        <router-link to="/register">{{ $t('common.createAccount') }}</router-link>
      </p>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';
import InputText from '@/components/inputs/InputText.vue'
import ButtonComponent from '@/components/buttons/ButtonComponent.vue';

export default defineComponent({
  name: 'HomeView',
  components: {
    InputText,
    ButtonComponent
  },
});
</script>

<style>
.custom-margin{
  margin-left: 170px;
  margin-top: 80px;
}
</style>
