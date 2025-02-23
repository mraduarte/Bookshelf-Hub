<template>
    <div>
        <div class="col-2 custom-margin mt-4 mb-3">
            <h2>{{ $t('common.createYourAccount') }}</h2>
        </div>

        <div class="col-3 custom-margin">
            <label class="d-block text-left">{{ $t('common.name') }}</label>
            <InputText type="text"></InputText>

            <label class="d-block text-left">{{ $t('common.user') }}</label>
            <InputText type="text"></InputText>

            <label class="d-block text-left">{{ $t('common.email') }}</label>
            <InputText type="email"></InputText>

            <label class="d-block text-left">{{ $t('common.password') }}</label>
            <InputText type="password"></InputText>

            <label class="d-block text-left">{{ $t('common.confirmPassword') }}</label>
            <InputText type="password"></InputText>

            <ButtonComponent type="submit" value="submit" :text="$t('common.register')"></ButtonComponent>
            
            <p class="mt-4">
                <router-link to="/login">{{ $t('common.doLogin') }}</router-link>
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
  margin-top: 10px;
}
</style>