import { useContext, FormEvent, useState } from 'react';
import Head from "next/head";
import styles from '../../styles/home.module.scss';
import LogoImg from '../../public/imagens/logo.png';
import Image from 'next/image';
import Input from "../components/ui/Input";
import Button from '../components/ui/Button';
import Link from 'next/link';

import { AuthContext } from '../contexts/AuthContext';

export default function Login() {
  const { signIn } = useContext(AuthContext);

  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');

  const [loading, setLoading] = useState(false);

  async function handleLogin(event: FormEvent) {
    event.preventDefault();

    if(email == '' || senha == ''){
      alert('Preencha os dados');
      return;
    }

    setLoading(true);

    let data = {
      email,
      senha
    }

    await signIn(data);

    setLoading(false);
  }

  return (
    <div>
      <Head>
        <title>Estética Malato</title>
      </Head>
      <div className={styles.containerCenter}>
        <Image src={LogoImg} alt="Logo Sujeiro Pizzaria" />

        <div className={styles.login}>

          <form onSubmit={handleLogin}>

            <Input
              type="text"
              placeholder="Digite seu E-Mail"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
            />

            <Input
              type="password"
              placeholder="Digite sua senha"
              value={senha}
              onChange={(e) => setSenha(e.target.value)}
            />

            <Button type="submit" loadding={loading} >Acessar</Button>
          </form>

          <Link href="/signup" className={styles.text}>
            Não possui uma conta? Cadastre-se
          </Link>
        </div>
      </div>
    </div>
  )
}