import { createContext, ReactNode, useState } from 'react';
import { destroyCookie, setCookie, parseCookies } from 'nookies';
import Router from 'next/router'
import { api } from '../services/apiClient';

type AuthContextData = {
  user: UserProps | undefined;
  isAuthenticated: boolean;
  signIn: (credentials: SignInProps) => Promise<void>;
  signOut: () => void;
}

type UserProps = {
  codigo: number;
  nome: string;
  email: string;
}

type SignInProps = {
  email: string;
  senha: string;
}

type AuthProviderProps = {
  children: ReactNode
}

export const AuthContext = createContext({} as AuthContextData);

export function signOut() {
  try {
    destroyCookie(undefined, '@esteticaauth.token');
    Router.push('/');
  } catch {
    console.log('erro ao deslogar');
  }
}

export function AuthProvider({ children }: AuthProviderProps) {

  const [user, setUser] = useState<UserProps>();
  const isAuthenticated = !!user;

  async function signIn({ email, senha }: SignInProps) {
    try {
      const response = await api.post('/login', {
        email,
        senha
      })

      const { codigo, nome, token } = response.data;

      console.log(codigo);
      console.log(nome);
      console.log(token);

      setCookie(undefined, '@esteticaauth.token', token, {
        maxAge: 60 * 60 * 24 * 2,
        path: "/"
      })

      setUser({
        codigo,
        nome,
        email
      });

      //passar para asproximas requisicoes o nosso token
      api.defaults.headers['Authorization'] = `Bearer ${token}`;

      //Redirecionar para /Dashboard
      Router.push("/dashboard");

    } catch (err) {
      console.log('Erro ao acessar', err);
    }
  }


  return (
    <AuthContext.Provider value={{ user, isAuthenticated, signIn, signOut }}>
      {children}
    </AuthContext.Provider>
  )
}