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
    background-color: $yellow;
    border-color: $yellow;
    color: $gray;
    width: 100%;
}
</style>