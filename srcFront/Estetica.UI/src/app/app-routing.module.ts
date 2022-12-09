import { UsuariosComponent } from './pages/usuarios/usuarios.component';
import { ClientesComponent } from './pages/clientes/clientes.component';
import { EmpresasComponent } from './pages/empresas/empresas.component';
import { AboutComponent } from './pages/about/about.component';
import { HomeComponent } from './pages/home/home.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'empresa', component: EmpresasComponent },
  { path: 'clientes', component: ClientesComponent },
  { path: 'usuarios', component: UsuariosComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
