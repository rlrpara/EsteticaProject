import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Retorno } from '../../models/retornoPaginacao';
import { ClienteLista } from '../models/clienteLista';
import { FiltroCliente } from '../models/filtroCliente';
import { Cliente } from './../models/cliente';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {
  private baseUrl = "http://localhost:5001/api/clientes";

  private httpOptions = {
    headers: new HttpHeaders({
      'Content-type': 'application/json'
    })
  }

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

  public Salvar(cliente: Cliente): Observable<number> {
    return this.http.post<number>(`${this.baseUrl}/inserir`, cliente);
  }
}
