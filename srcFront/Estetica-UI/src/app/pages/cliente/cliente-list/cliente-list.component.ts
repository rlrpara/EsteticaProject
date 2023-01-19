import { ClienteService } from './../services/cliente.service';
import { Component, OnInit } from '@angular/core';

import { ClienteLista } from './../model/clientelista';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './cliente-list.component.html',
  styleUrls: ['./cliente-list.component.css']
})
export class ClienteListComponent {

  clientes: ClienteLista[] = [];
  displayColumns = ['codigo', 'nome', 'nascimento', 'whatsapp', 'email'];

  constructor(
    private clienteService: ClienteService
    ) {
    this.clientes = clienteService.ObterTodos();
  }

}
