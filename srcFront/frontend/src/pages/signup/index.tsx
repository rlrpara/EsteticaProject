import { FormEvent, useState, useContext } from 'react';
import Head from "next/head";
import styles from '../../../styles/home.module.scss';
import LogoImg from '../../../public/imagens/logo.png';
import Image from 'next/image';
import Input from "../../components/ui/Input";
import Button from '../../components/ui/Button';
import Link from 'next/link';

import { AuthContext } from '../../contexts/AuthContext';

export default function Signup() {
  const { signUp } = useContext(AuthContext);
  const [nome, setNome] = useState('');
  const [email, setEmail] = useState('');
  const [senha, setSenha] = useState('');
  const [loading, setLoading] = useState(false);

  async function handleSignUp(event: FormEvent) {
    event.preventDefault();

    if (nome == '' || email == '' || senha == '') {
      alert('Preencha todos os campos');
      return;
    }

    setLoading(true);


  }

  return (
    <div>
      <Head>
        <title>Estética Malato: Faça seu cadastro agora</title>
      </Head>
      <div className={styles.containerCenter}>
        <Image src={LogoImg} alt="Logo Sujeiro Pizzaria" />

        <div className={styles.login}>
          <h1>Criando sua conta</h1>

          <form onSubmit={handleSignUp}>
            <Input
              type="text"
              placeholder="Digite seu Nome"
              value={nome}
              onChange={(e) => setNome(e.target.value)}
            />
            <Input
              type="text"
              placeholder="Digite seu E-Mail"
              value={email}
              onChange={(e) => setNome(e.target.value)}
            />
            <Input
              type="password"
              placeholder="Digite sua senha"
              value={senha}
              onChange={(e) => setNome(e.target.value)}
            />

            <Button type="submit" loadding={loading} >Cadastrar</Button>
          </form>

          <Link href="/" className={styles.text}>Já possui uma conta? Faça login!</Link>
        </div>
      </div>
    </div>
  )
}