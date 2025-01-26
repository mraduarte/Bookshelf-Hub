<template>
    <div>
        <input type="{{ type }}" class="form-control input-primary mb-4">
    </div>
</template>

<script>
    import { defineComponent } from 'vue';

    export default defineComponent ({
        name: 'InputText',
        props:{
            type: String,
        }
    });

</script>

<style lang="scss">
.input-primary{
    background-color: $gray-100;
}
</style>