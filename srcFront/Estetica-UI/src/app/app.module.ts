import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { ToastrModule } from 'ngx-toastr';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';
import { ClienteListComponent } from './pages/cliente/clientelist/clientelist.component';
import { AppNgxBootstrapModule } from './shared/app-ngx-bootstrap/app-ngx-bootstrap.module';

@NgModule({
  declarations: [
    AppComponent,
    ClienteListComponent,
    NavComponent,
    DateTimeFormatPipe,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AppNgxBootstrapModule,
    HttpClientModule,
    FormsModule,
    ToastrModule.forRoot(),
    TooltipModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
