// vue.config.js
module.exports = {
    css: {
      loaderOptions: {
        sass: {
          additionalData: `@import "~@/styles/variables.scss";`
        }
      }
    }
  }
  