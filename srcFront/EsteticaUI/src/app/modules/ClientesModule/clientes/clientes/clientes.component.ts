import { Component, OnInit } from '@angular/core';

import { ClienteLista } from '../models/clienteLista';
import { Retorno } from './../../../interface/retornoPaginacao';
import { ClienteService } from './../../services/cliente.service';
import { FiltroCliente } from './../models/filtroCliente';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.scss']
})
export class ClientesComponent implements OnInit {
  private _nome = "";

  public clientesLista: ClienteLista[] = [];
  public clientesFiltrados: ClienteLista[] = [];
  public displayedColumns: string[] = ['foto', 'codigo', 'nome', 'email', 'whatsapp', 'options'];

  public get Nome(): string {
    return this._nome;
  }

  public set Nome(value: string) {
    this._nome = value;
    this.clientesFiltrados = this.Nome ? this.filtroCliente(this.Nome) : this.clientesLista;
  }

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

    return this.clientesLista.filter(
      (cliente: any) => cliente.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  public obterTodos(): void {
    this.clienteService.ObterTodos(this.filtro).subscribe({
      next: (retorno: Retorno<ClienteLista[]>) => {
        this.clientesLista = retorno.dados;
        this.clientesFiltrados = this.clientesLista;
      },
      error: (error: any) => console.log(error)
    });
  }
}
