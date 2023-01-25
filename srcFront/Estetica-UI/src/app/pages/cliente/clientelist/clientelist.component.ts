import { Component, OnInit } from '@angular/core';
import { Retorno } from 'src/app/models/retornoPaginacao';

import { ClienteLista } from '../model/clienteLista';
import { FiltroCliente } from '../model/filtroCliente';
import { ClienteService } from '../services/cliente.service';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './clientelist.component.html',
  styleUrls: ['./clientelist.component.css']
})
export class ClienteListComponent implements OnInit {

  private _nome = "";
  private clientes: ClienteLista[] = [];

  public clientesFiltrados: ClienteLista[] = [];
  public displayColumns = ['codigo', 'nome', 'nascimento', 'whatsapp', 'email'];

  public get Nome(): string {
    return this._nome;
  }

  public set Nome(value: string) {
    this._nome = value;
    this.clientesFiltrados = this.Nome ? this.filtroCliente(this.Nome) : this.clientes;
  }

  widthImg = 150;
  exibirImagem = true;

  filtro: FiltroCliente = {
    paginaAtual: 1,
    quantidadePorPagina: 50,
    nome: this.Nome
  }

  constructor(
    private clienteService: ClienteService
  ) {
  }

  ngOnInit(): void {
    this.obterTodos();
  }

  public filtroCliente(filtrarPor: string): ClienteLista[] {
    filtrarPor = filtrarPor.toLocaleLowerCase();

    return this.clientes.filter(
      (cliente: any) => cliente.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  public alterarEstadoImagem(): void {
    this.exibirImagem = !this.exibirImagem;
  }

  public obterTodos(): void {
    this.clienteService.ObterTodos(this.filtro).subscribe({
      next: (retorno: Retorno<ClienteLista[]>) => {
        this.clientes = retorno.dados;
        this.clientesFiltrados = this.clientes;
      },
      error: (error: any) => console.log(error)
    });
  }

}
