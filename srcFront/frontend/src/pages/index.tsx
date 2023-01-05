import { useContext, FormEvent } from 'react';
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

  async function handleLogin(event: FormEvent ) {
    event.preventDefault();

    let data = {
      email: "rlr.para@gmail.com",
      senha: "123456"
    }

    await signIn(data);

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
            <Input type="text" placeholder="Digite seu E-Mail" />
            <Input type="password" placeholder="Digite sua senha" />

            <Button type="submit" loadding={false} >Acessar</Button>
          </form>

          <Link href="/signup" className={styles.text}>
            Não possui uma conta? Cadastre-se
          </Link>
        </div>
      </div>
    </div>
  )
}