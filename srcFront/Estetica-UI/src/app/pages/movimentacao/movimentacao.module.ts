import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';

import { MovimentacaoRoutingModule } from './movimentacao-routing.module';
import { MovimentacaoComponent } from './movimentacao/movimentacao.component';


@NgModule({
  declarations: [
    MovimentacaoComponent
  ],
  imports: [
    CommonModule,
    MovimentacaoRoutingModule
  ]
})
export class MovimentacaoModule { }
