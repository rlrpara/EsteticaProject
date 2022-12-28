import { ClientesService } from './../../services/ClientesServices/clientes.service';
import { ClienteDialogComponent } from './../../shared/cliente-dialog/cliente-dialog.component';
import { Component, OnInit } from '@angular/core';
import ClientesModel from 'src/app/models/ClientesModels';
import { MatDialog } from '@angular/material/dialog';
import filtroClienteModels from 'src/app/models/filtroClienteModels';
import { RetornoModels } from 'src/app/models/RetornoModels';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css'],
  providers: [ClientesService]
})
export class ClientesComponent implements OnInit {

  clientes!: RetornoModels;

  filtroCliente: filtroClienteModels = {
    nome: '',
    paginaAtual: 1,
    quantidadePorPagina: 50
  }

  displayedColumns: string[] = ['codigo', 'nome', 'nascimento', 'cpf', 'acoes'];

  constructor(
    public dialog: MatDialog,
    public clientesService: ClientesService
  ) {
    this.clientesService.obterTodos(this.filtroCliente)
      .subscribe(data => {
        console.log(data);
        this.clientes = data;
      })
  }

  ngOnInit(): void {
  }

  openDialog(clientes: ClientesModel | null) {
    const dialogRef = this.dialog.open(ClienteDialogComponent, {
      width: '900px',
      data: clientes != null ?
        clientes : {
          codigo: 1,
          nome: '',
          nascimento: null,
          cpf: ''
        },
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
      console.log(result);
      if (result != undefined) {
      }
    });
  }

  updateCliente(clientesModel: ClientesModel) {
    this.openDialog(clientesModel);
    if (this.clientes.dados.map(x => x.codigo).includes(clientesModel.codigo)) {
      this.clientesService.atualizar(clientesModel)
        .subscribe(data => {
          console.log(data);
          const saida = data;
        })
    } else {

    }

  }

  deleteCliente(codigo: number) {

  }
}


// parei em 01:09:01
// https://www.youtube.com/watch?v=LlmIF9wjqzE&list=PL2fQZkIXag6U_eGEbmnSQBSqFbGHRrBOn&index=6
