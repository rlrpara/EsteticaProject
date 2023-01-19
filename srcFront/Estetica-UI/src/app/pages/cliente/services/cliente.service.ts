import { Retorno } from './../../../modelApi/retorno';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { ClienteLista } from './../model/clientelista';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor(
    private http: HttpClient
  ) { }

  lista!: Retorno<ClienteLista[]>;

  ObterTodos(): ClienteLista[] {
    return [
      { codigo: 1, nome: 'Rosenira Malato Colares', nascimento: '12/07/1974', whatsapp: '(49) 98811-3948' },
      { codigo: 2, nome: 'Ana Lívia da Silva Malato', nascimento: '12/07/2017' },
    ];
  }
}
