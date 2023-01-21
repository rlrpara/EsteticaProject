import { FiltroCliente } from './../../../modelApi/filtroCliente';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Retorno } from './../../../modelApi/retorno';
import { ClienteLista } from './../model/clientelista';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  baseUrl = "http://localhost:5001/api/clientes/obtertodos";

  lista!: Retorno<ClienteLista[]>;

  constructor(
    private http: HttpClient
  ) {

  }

  ObterTodos(filtro: FiltroCliente): Observable<Retorno<ClienteLista[]>>{
    return this.http.post<Retorno<ClienteLista[]>>(this.baseUrl, filtro);
  }
}
