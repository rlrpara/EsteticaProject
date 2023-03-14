import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppMaterialModule } from './../shared/app-material/app-material.module';
import { ClienteDialogComponent } from './pages/cliente-dialog/cliente-dialog.component';
import { ClientesRoutingModule } from './clientes-routing.module';
import { ClientesComponent } from './pages/clientes-list/clientes-list.component';
import { ClienteFormComponent } from './pages/cliente-form/cliente-form.component';


@NgModule({
  declarations: [
    ClientesComponent,
    ClienteDialogComponent,
    ClienteFormComponent
  ],
  imports: [
    CommonModule,
    ClientesRoutingModule,
    AppMaterialModule,
    FormsModule,
    ReactiveFormsModule
  ]
})
export class ClientesModule { }
