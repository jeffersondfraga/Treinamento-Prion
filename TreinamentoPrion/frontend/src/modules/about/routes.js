/* eslint-disable import/prefer-default-export */
export const routes = [
  {
    path: '/about',
    component: () => import(/* webpackChunkName: "about" */ './About'),
    name: 'about',
  },
];

export default routes;
