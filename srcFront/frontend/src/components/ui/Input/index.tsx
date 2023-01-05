import { InputHTMLAttributes, TextareaHTMLAttributes } from 'react';
import styles from './input.module.scss';

interface IInputProps extends InputHTMLAttributes<HTMLInputElement>{};
interface ITextAreaProps extends InputHTMLAttributes<HTMLTextAreaElement>{};

export default function Input({ ...rest }: IInputProps) {
  return (
    <input className={styles.input} {...rest} />
  )
}

export function TextArea({...rest} : ITextAreaProps){
  return(
    <textarea className={styles.input} {...rest}></textarea>
  )
}