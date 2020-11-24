export const routes = [
  {
    path: '/',
    component: () => import(/* webpackChunkName: "home" */ './Home'),
    name: 'home',
  },
  {
    path: '/lista-pessoas',
    component: () => import(/* webpackChunkName: "home" */ './ListaPessoa'),
    name: 'lista.pessoas',
  },
];

export default routes;
