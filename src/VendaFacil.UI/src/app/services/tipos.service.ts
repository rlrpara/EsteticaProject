import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { filtroTipo } from '../model/filtros/filtroTipo';
import { Tipo } from '../model/Tipo';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-type': 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class TiposService {

  url: string = 'api/tipo';

  constructor(private http: HttpClient) { }

  ObterTodos(filtro: filtroTipo) : Observable<Tipo>{
    const apiUrl = `${this.url}/obtertodos`;
    return this.http.post<Tipo>(apiUrl, filtro, httpOptions);
  }

  ObterPorId(codigo : number): Observable<Tipo>{
    const apiUrl = `${this.url}/obterporid/${codigo}`;
    return this.http.get<Tipo>(apiUrl);
  }

  Inserir(tipo: Tipo): Observable<any>{
    const apiUrl = `${this.url}/inserir`;
    return this.http.post<Tipo>(apiUrl, tipo, httpOptions);
  }

  Atualizar(tipo: Tipo): Observable<any>{
    const apiUrl = `${this.url}/atualizar`;
    return this.http.put<Tipo>(apiUrl, tipo, httpOptions);
  }

  Deletar(codigo: number): Observable<any>{
    const apiUrl = `${this.url}/deletar/${codigo}`;
    return this.http.delete<number>(apiUrl);
  }
}
