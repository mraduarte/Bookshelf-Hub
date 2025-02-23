<template>
    <div>
        <button class="btn btn-primary" type="{{type}}">{{text}}</button>
    </div>
</template>

<script>

import { defineComponent } from 'vue';

    export default defineComponent ({
        name: 'ButtonComponent',
        props:{
            type: String,
            value: String,
            text: String
        }
    });
</script>

<style lang="scss">

.btn-primary{
    background-color: $pink-200;
    border-color: $pink-200;
    color: $gray;
    width: 100%;

    &:hover{
        background-color: $yellow-400;
        border-color: $yellow-400;
        color: $gray;
    }
}
</style>