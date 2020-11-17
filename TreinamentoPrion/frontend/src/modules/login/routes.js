export const routes = [
  {
    path: '/login',
    component: () => import(/* webpackChunckName: "login" */ './Login'),
    name: 'login',
  },
];

export default routes;
