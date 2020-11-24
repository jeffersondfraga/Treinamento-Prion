import baseAPI from '@/http';

const router = 'api/pessoa';

// eslint-disable-next-line import/prefer-default-export
export const pessoaAPI = {
  get: (id) => baseAPI.get(`${router}/${id}`),
  list: () => baseAPI.get(router),
  create: (pessoa) => baseAPI.post(router, pessoa),
  update: (pessoa) => baseAPI.put(router, pessoa),
  delete: (id) => baseAPI.delete(`${router}/${id}`),
};
