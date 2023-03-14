import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

import { Retorno } from '../../../shared/models/retornoPaginacao';
import { ClienteLista } from '../../models/clienteLista';
import { FiltroCliente } from '../../models/filtroCliente';
import { ClienteService } from '../../services/cliente.service';
import { ClienteDialogComponent } from '../cliente-dialog/cliente-dialog.component';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes-list.component.html',
  styleUrls: ['./clientes-list.component.scss']
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
    private clienteService: ClienteService,
    public dialog: MatDialog
  ) {

  }

  novoCliente(): void {
    const dialogRef = this.dialog.open(ClienteDialogComponent, {
      minWidth: '72%',
    });

    dialogRef.afterClosed().subscribe(result => {
      this.obterTodos();
      console.log('The dialog was closed');
    });
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
