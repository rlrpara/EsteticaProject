import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { TipoPessoa } from './../../ClientesModule/models/tipoPessoa';
import { FiltroTipoPessoa } from './../model/filtroTipoPessoa';

@Injectable({
  providedIn: 'root'
})
export class TipopessoaService {
  private baseUrl = "http://localhost:5001/api/tipopessoa";
  private baseUrlHomologacao = "https://localhost:44304/api/tipopessoa";

  public lista!: TipoPessoa[];

  constructor(
    private http: HttpClient
  ) { }

  public ObterTodos(filtro: FiltroTipoPessoa): Observable<TipoPessoa[]>{
    return this.http.post<TipoPessoa[]>(`${this.baseUrl}/obtertodos`, filtro);
  }

}
