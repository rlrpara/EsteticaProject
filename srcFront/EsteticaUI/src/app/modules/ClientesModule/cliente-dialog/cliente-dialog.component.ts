import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';

import { Cliente } from './../models/cliente';
import { ClienteService } from './../services/cliente.service';

@Component({
  selector: 'app-cliente-dialog',
  templateUrl: './cliente-dialog.component.html',
  styleUrls: ['./cliente-dialog.component.scss']
})
export class ClienteDialogComponent implements OnInit {

  private valorSaida: number = 0;
  public formCliente!: FormGroup;

  constructor(
    public dialogRef: MatDialogRef<ClienteDialogComponent>,
    private clienteService: ClienteService,
    private _snackBar: MatSnackBar,
    private formBuilder: FormBuilder
  ){}

  ngOnInit(): void {
    this.criarForm();
  }

  criarForm(){
    this.formCliente = this.formBuilder.group({
      codigo: [{ value: '', disabled: true }],
      numeroProntuario: [null],
      numeroCartaoFidelidade: [null],
      nome: [null, [Validators.required]],
      nascimento: [null],
      codigoTipoPessoa: [null],
      cpfcnpj: [null, [Validators.required]],
      orgaoEmissor: [null],
      inscricaoMunicipal: [null],
      inscricaoEstadual: [null],
      whatsapp: [null],
      email: [null],
      celular: [null],
      foto: [null],
      cep: [null],
      codigoTipoEndereco: [null],
      endereco: [null],
      numero: [null],
      bairro: [null],
      complemento: [null],
      codigoUf: [null],
      cidade: [null],
      observacao: [null],
      origemIndicacao: [null],
      origemParcerias: [null],
      origemProfissional: [null],
      origemCliente: [null],
      origemCampanha: [null],
      codigoEstabelecimentoOrigem: [null],
      origemMarketing: [null],
      naturalidade: [null],
      nomePai: [null],
      nomeMae: [null],
      profissao: [null],
      localTrabalho: [null],
      codigoSexo: [null],
      codigoEstadoCivil: [null],
      codigoTipoSnaguineo: [null],
      codigoTipoCliente: [null],
      dataCadastro: [new Date().toLocaleDateString("pt-BR"), [Validators.nullValidator]],
      dataAtualizacao: [new Date().toLocaleDateString("pt-BR"), [Validators.nullValidator]],
      ativo: [null],
    });
  }

  public cancel(): void {
    this.dialogRef.close();
  }

  public Salvar(): void {
    console.log(this.formCliente.invalid);

    if(this.formCliente.invalid) return;
    var cliente = this.formCliente.getRawValue() as Cliente;

    this.clienteService.Salvar(cliente).subscribe(result => {
      this.valorSaida = result;
    });
    this.openSnackBar(this.valorSaida > 0 ? 'Registro salvo' : 'Erro ao salvar registro', 'X');
    this.dialogRef.close();
    this.formCliente.reset();
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 1000
    });
  }
  // public Salvar(): void {
  //   this.clienteService.Salvar(this.cliente).subscribe({
  //     next: (retorno: number) => {
  //       this.valorSaida = retorno;
  //       console.log(retorno);
  //     },
  //     error: (error: any) => console.log(error)
  //   });
  // }
}
