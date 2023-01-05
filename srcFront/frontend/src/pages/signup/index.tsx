import Head from "next/head";
import styles from '../../../styles/home.module.scss';
import LogoImg from '../../../public/imagens/logo.png';
import Image from 'next/image';
import Input from "../../components/ui/Input";
import Button from '../../components/ui/Button';
import Link from 'next/link';

export default function Signup() {
  return (
    <div>
      <Head>
        <title>Estética Malato: Faça seu cadastro agora</title>
      </Head>
      <div className={styles.containerCenter}>
        <Image src={LogoImg} alt="Logo Sujeiro Pizzaria" />

        <div className={styles.login}>
          <h1>Criando sua conta</h1>
          <form>
            <Input type="text" placeholder="Digite seu Nome" />
            <Input type="text" placeholder="Digite seu E-Mail" />
            <Input type="password" placeholder="Digite sua senha" />

            <Button type="submit" loadding={false} >Cadastrar</Button>
          </form>
          
          <Link href="/" className={styles.text}>Já possui uma conta? Faça login!</Link>
        </div>
      </div>
    </div>
  )
}