import { createI18n } from 'vue-i18n';
import pt from '../locales/pt.json';


const i18n = createI18n({
  locale: 'pt',
  fallbackLocale: 'pt',
  messages: {
    pt
  }
});

export default i18n;
