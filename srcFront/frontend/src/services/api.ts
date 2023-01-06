import axios, { AxiosError } from 'axios';
import { parseCookies } from 'nookies';
import { AuthTokenError } from './errors/AuthTokenError';
import { signOut } from '../contexts/AuthContext';

export function setupAPIClient(contexto = undefined) {
  let cookies = parseCookies(contexto);

  const api = axios.create({
    baseURL: 'http://localhost:5001/api',
    headers: {
      Authorization: `Bearer ${cookies['@esteticaauth.token']}`
    }
  })

  api.interceptors.response.use(response => {
    return response;
  }, (error: AxiosError) => {
    if (error.response?.status === 401) {
      //qualquer erro 401(nao autorizado) devemos deslogar o usuario
      if (typeof window !== undefined) {
        //chamar a funcao para deslogar o usuario
        signOut();
      } else {
        return Promise.reject(new AuthTokenError());
      }
    }

    return Promise.reject(error);

  })

  return api;
}