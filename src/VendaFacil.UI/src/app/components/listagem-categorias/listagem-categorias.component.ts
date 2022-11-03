import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { filtroCategoria } from 'src/app/model/filtros/filtroCategoria';
import { CategoriaService } from 'src/app/services/categoria.service';

@Component({
  selector: 'app-listagem-categorias',
  templateUrl: './listagem-categorias.component.html',
  styleUrls: ['./listagem-categorias.component.css']
})
export class ListagemCategoriasComponent implements OnInit {

  categorias = new MatTableDataSource<any>();
  displayColumns: string[]|undefined;

  filtro = new filtroCategoria();

  constructor(private categoriaService: CategoriaService) { }

  ngOnInit(): void {
    this.categoriaService.ObterTodos(this.filtro).subscribe(resultado => {
      this.categorias.data = resultado;
    });

    this.displayColumns = this.ExibirColunas();
  }

  ExibirColunas(): string[]{
    return ['nome', 'icone', 'tipo', 'acoes'];
  }

}
