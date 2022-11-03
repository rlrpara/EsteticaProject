import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListagemCategoriasComponent } from './components/listagem-categorias/listagem-categorias.component';

const routes: Routes = [
  { path: 'categoria/listagemcategorias', component: ListagemCategoriasComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
