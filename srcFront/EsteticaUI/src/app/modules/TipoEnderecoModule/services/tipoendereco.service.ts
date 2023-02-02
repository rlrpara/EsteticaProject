import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { TipoEndereco } from './../../models/tipoEndereco';

@Injectable({
  providedIn: 'root'
})
export class TipoenderecoService {
  private baseUrl = "http://localhost:5001/api/tipoendereco";

  public lista!: TipoEndereco[];

  constructor(
    private http: HttpClient
  ) { }

  public ObterTodos(): Observable<TipoEndereco[]>{
    return this.http.get<TipoEndereco[]>(`${this.baseUrl}/obtertodos`);
  }
}
