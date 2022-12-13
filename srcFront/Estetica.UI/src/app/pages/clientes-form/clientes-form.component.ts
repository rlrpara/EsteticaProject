import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-clientes-form',
  templateUrl: './clientes-form.component.html',
  styleUrls: ['./clientes-form.component.css']
})
export class ClientesFormComponent implements OnInit {
  @Input() btnText!: string;

  clientesForm!: FormGroup;

  constructor() { }

  ngOnInit(): void {
    this.clientesForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl(''),
      nascimento: new FormControl(''),
      cpfcnpj: new FormControl(''),
      endereco: new FormControl(''),
      cidade: new FormControl(''),
      uf: new FormControl(''),

    });
  }

  submit() {
    console.log("Enviou o formulario");
  }

}
