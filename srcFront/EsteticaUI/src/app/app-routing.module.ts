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
        loadChildren: () => import('./modules/ClientesModule/clientes.module').then(x => x.ClientesModule)
      },
      {
        path: 'dashboard',
        loadChildren: () => import('./modules/DashboardModule/dashboard.module').then(x => x.DashboardModule)
      },
      {
        path: 'empresa',
        loadChildren: () => import('./modules/EmpresaModule/empresa/empresa.module').then(x => x.EmpresaModule)
      },
      {
        path: 'movimentacao',
        loadChildren: () => import('./modules/MovimentacaoModule/movimentacao/movimentacao.module').then(x => x.MovimentacaoModule)
      },
      {
        path: 'agenda',
        loadChildren: () => import('./modules/AgendaModule/agenda/agenda.module').then(x => x.AgendaModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
