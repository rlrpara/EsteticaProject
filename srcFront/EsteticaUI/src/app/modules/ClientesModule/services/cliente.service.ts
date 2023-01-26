import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { ClienteLista } from '../clientes/models/clienteLista';
import { Retorno } from './../../interface/retornoPaginacao';
import { FiltroCliente } from './../clientes/models/filtroCliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  private baseUrl = "http://localhost:5001/api/clientes";

  public lista!: Retorno<ClienteLista[]>;

  constructor(
    private http: HttpClient
  ) {

  }

  public ObterTodos(filtro: FiltroCliente): Observable<Retorno<ClienteLista[]>>{
    return this.http.post<Retorno<ClienteLista[]>>(`${this.baseUrl}/obtertodos`, filtro);
  }

  public ObterPorId(id: number): Observable<Retorno<ClienteLista[]>>{
    return this.http.get<Retorno<ClienteLista[]>>(`${this.baseUrl}/${id}`);
  }
}
