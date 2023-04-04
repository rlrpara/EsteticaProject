import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { ClientesRoutingModule } from './clientes-routing.module';
import { ClienteComponent } from './cliente/cliente.component';


@NgModule({
  declarations: [
    ClienteComponent
  ],
  imports: [
    CommonModule,
    ClientesRoutingModule
  ]
})
export class ClientesModule { }
