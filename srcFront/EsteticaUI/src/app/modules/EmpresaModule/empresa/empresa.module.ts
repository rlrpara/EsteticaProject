import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AppMaterialModule } from './../../shared/app-material/app-material.module';
import { EmpresaRoutingModule } from './empresa-routing.module';
import { EmpresaComponent } from './empresa/empresa.component';


@NgModule({
  declarations: [
    EmpresaComponent
  ],
  imports: [
    CommonModule,
    EmpresaRoutingModule,
    AppMaterialModule
  ]
})
export class EmpresaModule { }
