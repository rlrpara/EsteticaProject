import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NavComponent } from './template/nav/nav.component';

const routes: Routes = [
  {
    path: '', component: NavComponent,
    children: [
      {
        path: '',
        pathMatch: 'full',
        redirectTo: 'dashboard'
      },
      {
        path: 'clientes',
        loadChildren: () => import('./modules/Clientes/clientes.module').then(x => x.ClientesModule)
      },
      {
        path: 'dashboard',
        loadChildren: () => import('./modules/Dashboard/dashboard.module').then(x => x.DashboardModule)
      },
      {
        path: 'empresa',
        loadChildren: () => import('./modules/Empresa/empresa/empresa.module').then(x => x.EmpresaModule)
      },
      {
        path: 'movimentacao',
        loadChildren: () => import('./modules/Movimentacao/movimentacao/movimentacao.module').then(x => x.MovimentacaoModule)
      },
      {
        path: 'agenda',
        loadChildren: () => import('./modules/Agenda/agenda/agenda.module').then(x => x.AgendaModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
