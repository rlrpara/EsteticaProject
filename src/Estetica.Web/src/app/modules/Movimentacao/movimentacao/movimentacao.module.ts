import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { AppMaterialModule } from './../../shared/app-material/app-material.module';
import { MovimentacaoRoutingModule } from './movimentacao-routing.module';
import { MovimentacaoComponent } from './movimentacao/movimentacao.component';


@NgModule({
  declarations: [
    MovimentacaoComponent
  ],
  imports: [
    CommonModule,
    MovimentacaoRoutingModule,
    AppMaterialModule
  ]
})
export class MovimentacaoModule { }
