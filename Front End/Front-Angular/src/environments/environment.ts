export const environment = {
  production: false,
  apiUrl: '',
  auth: {
      baseUrl: '',
      loginUrl: '/sso/login',
      logoutUrl: '/logout',
      detailsUrl: '/user/details',
      tokenValidationUrl: '/token/validate',
      storage: localStorage,
      userStorageIndex: 'user',
      loginSuccessRoute: '/#/login-success'
  }
};