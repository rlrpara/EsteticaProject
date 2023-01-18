import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "login" },
  {
    path: "login",
    loadChildren: () => import('./pages/login/login-routing.module').then(x => x.LoginRoutingModule)
  },
  {
    path: "cliente",
    loadChildren: () => import('./pages/cliente/cliente-routing.module').then(x => x.ClienteRoutingModule)
  },
  {
    path: "empresa",
    loadChildren: () => import('./pages/empresa/empresa-routing.module').then(x => x.EmpresaRoutingModule)
  },
  {
    path: "mocimentacao",
    loadChildren: () => import('./pages/movimentacao/movimentacao-routing.module').then(x => x.MovimentacaoRoutingModule)
  },
  {
    path: "usuario",
    loadChildren: () => import('./pages/usuario/usuario-routing.module').then(x => x.UsuarioRoutingModule)
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
