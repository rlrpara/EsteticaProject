import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppMaterialModule } from './../shared/app-material/app-material.module';
import { ClienteDialogComponent } from './cliente-dialog/cliente-dialog.component';
import { ClientesRoutingModule } from './clientes-routing.module';
import { ClientesComponent } from './clientes/clientes.component';


@NgModule({
  declarations: [
    ClientesComponent,
    ClienteDialogComponent
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
