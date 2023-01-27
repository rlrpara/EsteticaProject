import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
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
      codigo: [null, [Validators.nullValidator]],
      numeroProntuario: [null, [Validators.nullValidator]],
      numeroCartaoFidelidade: ['', [Validators.nullValidator]],
      nome: ['', [Validators.required]],
      nascimento: ['', [Validators.nullValidator]],
      codigoTipoPessoa: ['', [Validators.nullValidator]],
      cpfcnpj: ['', [Validators.required]],
      orgaoEmissor: ['', [Validators.nullValidator]],
      inscricaoMunicipal: ['', [Validators.nullValidator]],
      inscricaoEstadual: ['', [Validators.nullValidator]],
      whatsapp: ['', [Validators.nullValidator]],
      email: ['', [Validators.nullValidator]],
      celular: ['', [Validators.nullValidator]],
      foto: ['', [Validators.nullValidator]],
      cep: ['', [Validators.nullValidator]],
      codigoTipoEndereco: ['', [Validators.nullValidator]],
      endereco: ['', [Validators.nullValidator]],
      numero: ['', [Validators.nullValidator]],
      bairro: ['', [Validators.nullValidator]],
      complemento: ['', [Validators.nullValidator]],
      codigoUf: ['', [Validators.nullValidator]],
      cidade: ['', [Validators.nullValidator]],
      observacao: ['', [Validators.nullValidator]],
      origemIndicacao: ['', [Validators.nullValidator]],
      origemParcerias: ['', [Validators.nullValidator]],
      origemProfissional: ['', [Validators.nullValidator]],
      origemCliente: ['', [Validators.nullValidator]],
      origemCampanha: ['', [Validators.nullValidator]],
      codigoEstabelecimentoOrigem: ['', [Validators.nullValidator]],
      origemMarketing: ['', [Validators.nullValidator]],
      naturalidade: ['', [Validators.nullValidator]],
      nomePai: ['', [Validators.nullValidator]],
      nomeMae: ['', [Validators.nullValidator]],
      profissao: ['', [Validators.nullValidator]],
      localTrabalho: ['', [Validators.nullValidator]],
      codigoSexo: ['', [Validators.nullValidator]],
      codigoEstadoCivil: ['', [Validators.nullValidator]],
      codigoTipoSnaguineo: ['', [Validators.nullValidator]],
      codigoTipoCliente: ['', [Validators.nullValidator]],
      dataCadastro: [new Date().toLocaleDateString("pt-BR"), [Validators.nullValidator]],
      dataAtualizacao: [new Date().toLocaleDateString("pt-BR"), [Validators.nullValidator]],
      ativo: ['', [Validators.nullValidator]],
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
