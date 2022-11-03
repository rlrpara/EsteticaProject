import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Categoria } from '../model/Categoria';
import { filtroCategoria } from '../model/filtros/filtroCategoria';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-type': 'application/json'
  })
}

@Injectable({
  providedIn: 'root'
})
export class CategoriaService {

  url: string = 'api/categoria';

  constructor(private http: HttpClient) { }

  ObterTodos(filtro: filtroCategoria): Observable<Categoria[]>{
    const apiUrl = `${this.url}/obtertodos`;
    return this.http.post<Categoria[]>(apiUrl, filtro, httpOptions)
  }

  ObterPorId(codigo: number): Observable<Categoria>{
    const apiUrl = `${this.url}/obterporid/${codigo}`;
    return this.http.get<Categoria>(apiUrl);
  }

  Inserir(categoria: Categoria): Observable<any>{
    const apiUrl = `${this.url}/inserir`;
    return this.http.post<Categoria>(apiUrl, categoria, httpOptions);
  }

  Atualizar(categoria: Categoria): Observable<any>{
    const apiUrl = `${this.url}/atualizar`;
    return this.http.put<Categoria>(apiUrl, categoria, httpOptions);
  }

  Delete(codigo: number): Observable<any>{
    const apiUrl = `${this.url}/delete/${codigo}`;
    return this.http.delete<number>(apiUrl)
  }
}
