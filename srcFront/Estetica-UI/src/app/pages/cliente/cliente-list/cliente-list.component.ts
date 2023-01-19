import { Component, OnInit } from '@angular/core';

import { ClienteLista } from './../model/clientelista';

@Component({
  selector: 'app-cliente-list',
  templateUrl: './cliente-list.component.html',
  styleUrls: ['./cliente-list.component.css']
})
export class ClienteListComponent implements OnInit {

  clientes: ClienteLista[] = [
    { codigo: 1, nome: 'Rosenira Malato Colares', nascimento: '12/07/1974' },
    { codigo: 2, nome: 'Ana Lívia da Silva Malato', nascimento: '12/07/2017' },
  ];
  displayColumns = ['codigo', 'nome', 'nascimento', 'whatsapp', 'email'];

  constructor() {
  }

  ngOnInit(): void {
  }

}
