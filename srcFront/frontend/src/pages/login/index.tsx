import Head  from "next/head";
import styles from './login.module.scss';
import LogoImg from '../../../public/logo.svg';
import Image from 'next/image';
import Input from "../../components/ui/Input";
import Button from '../../components/ui/Button';

export default function Login(){
  return(
    <div>
      <Head>
        <title>Login</title>
      </Head>
      <div className={styles.containerCenter}>
        <Image src={LogoImg} alt="Logo Sujeiro Pizzaria" />

        <div className={styles.login}>
          <form>
            <Input type="text" placeholder="Digite seu E-Mail" />
            <Input type="password" placeholder="Digite sua senha" />

            <Button type="submit" loadding={false} >Acessar</Button>
          </form>
        </div>
      </div>
    </div>
  )
}