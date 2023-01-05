import { ButtonHTMLAttributes, ReactNode } from 'react';
import styles from './button.module.scss';

import { FaSpinner } from 'react-icons/fa';

interface IButtonProps extends ButtonHTMLAttributes<HTMLButtonElement> {
  loadding?: boolean;
  children: ReactNode
}

export default function Button({ loadding, children, ...rest }: IButtonProps) {
  return (
    <button
      className={styles.button}
      disabled={loadding}
      {...rest}
    >
      {loadding ? (
        <FaSpinner color="#fff" size={16} />
      ) : (
        <a className={styles.buttonText}>
          {children}
        </a>
      )}

    </button>
  )
}