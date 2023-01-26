import { NgModule } from '@angular/core';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';


@NgModule({
  exports: [
    CollapseModule,
    BsDropdownModule
  ]
})
export class AppNgxBootstrapModule { }
