import { TipoEndereco } from './../../models/tipoEndereco';
import { TipoenderecoService } from './../../TipoEnderecoModule/services/tipoendereco.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';

import { FiltroTipoPessoa } from './../../TipoPessoaModule/model/filtroTipoPessoa';
import { TipopessoaService } from './../../TipoPessoaModule/services/tipopessoa.service';
import { TipoPessoa } from './../models/tipoPessoa';
import { ClienteService } from './../services/cliente.service';

@Component({
  selector: 'app-cliente-dialog',
  templateUrl: './cliente-dialog.component.html',
  styleUrls: ['./cliente-dialog.component.scss']
})
export class ClienteDialogComponent implements OnInit {

  private filtroTipoPessoa!: FiltroTipoPessoa;
  valorSaida: number = 0;
  formCliente!: FormGroup;
  listaTipoPessoa!: TipoPessoa[];
  listTipoEndereco!: TipoEndereco[];
  tipoPessoaSelected: any = {
    selected: 1
  }

  constructor(
    public dialogRef: MatDialogRef<ClienteDialogComponent>,
    private _clienteService: ClienteService,
    private _tipoPessoaService: TipopessoaService,
    private _tipoEndereco: TipoenderecoService,
    private _snackBar: MatSnackBar,
    private _formBuilder: FormBuilder
  ){
    this.filtroTipoPessoa = {
      descricao: ''
    }
    this.criarForm(_formBuilder);
  }

  ngOnInit(): void {
    this._tipoPessoaService.ObterTodos(this.filtroTipoPessoa).subscribe({
      next: (retorno: TipoPessoa[]) => {
        console.log(retorno);
        this.listaTipoPessoa = retorno;
      },
      error: (err: Error) => console.log(err)
    });

    this._tipoEndereco.ObterTodos().subscribe({
      next: (retorno: TipoEndereco[]) => {
        this.listTipoEndereco = retorno;
      },
      error: (err: Error) => console.log(err)
    })
  }

  criarForm(formBuilder: FormBuilder){
    this.formCliente = formBuilder.group({
      codigo: [''],
      numeroProntuario: [''],
      numeroCartaoFidelidade: [''],
      nome: [''],
      nascimento: [''],
      codigoTipoPessoa: [''],
      cpfcnpj: [''],
      orgaoEmissor: [''],
      inscricaoMunicipal: [''],
      inscricaoEstadual: [''],
      whatsapp: [''],
      email: [''],
      celular: [''],
      foto: [''],
      cep: [''],
      codigoTipoEndereco: [''],
      endereco: [''],
      numero: [''],
      bairro: [''],
      complemento: [''],
      codigoUf: [''],
      cidade: [''],
      observacao: [''],
      origemIndicacao: [''],
      origemParcerias: [''],
      origemProfissional: [''],
      origemCliente: [''],
      origemCampanha: [''],
      codigoEstabelecimentoOrigem: [''],
      origemMarketing: [''],
      naturalidade: [''],
      nomePai: [''],
      nomeMae: [''],
      profissao: [''],
      localTrabalho: [''],
      codigoSexo: [''],
      codigoEstadoCivil: [''],
      codigoTipoSnaguineo: [''],
      codigoTipoCliente: [''],
      dataCadastro: [''],
      dataAtualizacao: [''],
      ativo: true,
    });
  }

  public cancel(): void {
    this.dialogRef.close();
  }

  onFormSubmit() {
    if(this.formCliente.valid){
      console.log(this.formCliente.value);
    }
  };

  public Salvar(): void {
    if(this.formCliente.invalid) return;



    // var cliente = this.formCliente.getRawValue() as Cliente;
    // this.clienteService.Salvar(cliente).subscribe(result => {
    //   this.valorSaida = result;
    // });
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
