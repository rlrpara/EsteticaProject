import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


const routes: Routes = [
  {
    path: "",
    pathMatch: "full",
    redirectTo: "dashboard"
  },
  {
    path: "login",
    loadChildren: () => import('./pages/login/login.module').then(x => x.LoginModule)
  },
  {
    path: "cliente",
    loadChildren: () => import('./pages/cliente/cliente.module').then(x => x.ClienteModule)
  },
  {
    path: "empresa",
    loadChildren: () => import('./pages/empresa/empresa.module').then(x => x.EmpresaModule)
  },
  {
    path: "movimentacao",
    loadChildren: () => import('./pages/movimentacao/movimentacao.module').then(x => x.MovimentacaoModule)
  },
  {
    path: "usuario",
    loadChildren: () => import('./pages/usuario/usuario.module').then(x => x.UsuarioModule)
  },
  {
    path: "dashboard",
    loadChildren: () => import('./pages/dashboard/dashboard-routing.module').then(x => x.DashboardRoutingModule)
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
