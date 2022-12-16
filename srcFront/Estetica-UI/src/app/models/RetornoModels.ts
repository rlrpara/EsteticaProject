import ClientesModel from "./ClientesModels";

export interface RetornoModels {
  paginacao: Paginacao;
	dados: ClientesModel[];
};

interface Paginacao {
  paginaAtual: number,
  quantidadePorPagina: number,
  totalPagina: number,
  totalRegistros: number
}
