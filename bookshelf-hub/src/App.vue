<template>
  <nav>
    <header>
      <div class="header">
        <div>{{ $t('common.bookshelfHub') }}</div>
        <div>
          <ButtonComponent type="submit" value="submit" :text="$t('common.login')"></ButtonComponent>
        </div>
      </div>
    </header>
  </nav>
  <router-view/>
</template>

<script>
  import { defineComponent } from 'vue';
  import ButtonComponent from '@/components/buttons/ButtonComponent.vue';

  export default defineComponent({
    name: 'LoginView',
    components: {
      ButtonComponent
    },
  });
</script>

<style lang="scss">
#app {
  font-family: 'Noto serif';
  color: $gray-800;
}

.header{
  display: flex;
  justify-content: space-between;
  width: 100%;
  padding: 20px 30px;
  font-size: larger;
  font-weight: 500;
  border-bottom: 1px solid $gray-100;
  background-color: $yellow-100;
  height: 90px;

  > div:first-child {
    flex-grow: 1;
    text-align: center;
    font-size: 2rem;
  }
}
</style>
