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
        loadChildren: () => import('./modules/ClientesModule/clientes/clientes.module').then(x => x.ClientesModule)
      },
      {
        path: 'dashboard',
        loadChildren: () => import('./modules/DashboardModule/dashboard/dashboard.module').then(x => x.DashboardModule)
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
