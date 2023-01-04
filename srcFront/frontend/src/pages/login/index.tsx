import Head  from "next/head";
import styles from './login.module.scss';
import LogoImg from '../../../public/logo.svg';
import Image from 'next/image';

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
            <input type="text" />
          </form>
        </div>
      </div>
    </div>
  )
}