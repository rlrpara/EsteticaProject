import { Component, OnInit } from '@angular/core';

import { FiltroCliente } from './../../../modelApi/filtroCliente';
import { Retorno } from './../../../modelApi/retorno';
import { ClienteLista } from './../model/clientelista';
import { ClienteService } from './../services/cliente.service';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './cliente-list.component.html',
  styleUrls: ['./cliente-list.component.css']
})
export class ClienteListComponent implements OnInit {

  clientes: any = [];
  clientesFiltrados: any = [];
  displayColumns = ['codigo', 'nome', 'nascimento', 'whatsapp', 'email'];
  _nome = "";

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
    nome: ''
  }

  constructor(
    private clienteService: ClienteService
  ) {
  }

  ngOnInit(): void {
    this.clienteService.ObterTodos(this.filtro).subscribe(retorno => {
      this.clientes = retorno.dados;
      this.clientesFiltrados = this.clientes;
    },
    error => console.log(error)
    );
  }

  filtroCliente(filtrarPor: string): any {
    filtrarPor = filtrarPor.toLocaleLowerCase();

    return this.clientes.filter(
      (cliente: any) => cliente.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    )
  }

  alterarEstadoImagem() {
    this.exibirImagem = !this.exibirImagem;
  }

}
