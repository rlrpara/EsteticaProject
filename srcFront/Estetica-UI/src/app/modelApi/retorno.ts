export interface Retorno<T> {
  paginaAtual?: number;
  quantidadePorPagina?: number;
  nome?: string;
  dados?: T[];
}
