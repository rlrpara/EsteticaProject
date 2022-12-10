import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-clientes-form',
  templateUrl: './clientes-form.component.html',
  styleUrls: ['./clientes-form.component.css']
})
export class ClientesFormComponent implements OnInit {
  @Input() btnText!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
