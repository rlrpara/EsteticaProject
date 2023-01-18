import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AppMaterialModule } from './../../shared/app-material/app-material.module';
import { UsuarioRoutingModule } from './usuario-routing.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    UsuarioRoutingModule,
    AppMaterialModule
  ]
})
export class UsuarioModule { }
