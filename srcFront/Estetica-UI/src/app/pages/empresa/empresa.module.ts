import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AppMaterialModule } from './../../shared/app-material/app-material.module';
import { EmpresaRoutingModule } from './empresa-routing.module';


@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    EmpresaRoutingModule,
    AppMaterialModule
  ]
})
export class EmpresaModule { }
