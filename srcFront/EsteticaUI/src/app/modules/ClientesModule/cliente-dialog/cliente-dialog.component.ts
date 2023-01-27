import { Cliente } from './../models/cliente';
import { ClienteService } from './../services/cliente.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-cliente-dialog',
  templateUrl: './cliente-dialog.component.html',
  styleUrls: ['./cliente-dialog.component.scss']
})
export class ClienteDialogComponent implements OnInit {

  private valorSaida: number = 0;
  public formGroup!: FormGroup;

  private cliente: Cliente = {
    nome: 'ana livia da silva malato',
    cpfcnpj: '25741591523',
    ativo: true
  }

  constructor(
    public dialogRef: MatDialogRef<ClienteDialogComponent>,
    private fb: FormBuilder,
    private clienteService: ClienteService,
    private _snackBar: MatSnackBar
  ){}

  ngOnInit(): void {
      this.formGroup = this.fb.group({
          codigo: ['', [Validators.nullValidator]],
          numeroProntuario: ['', [Validators.nullValidator]],
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
          dataCadastro: ['', [Validators.nullValidator]],
          dataAtualizacao: ['', [Validators.nullValidator]],
          ativo: ['', [Validators.nullValidator]],
      })
  }

  public cancel(): void {
    this.dialogRef.close();
    this.formGroup.reset();
  }

  public Salvar(): void {
    this.clienteService.Salvar(this.cliente).subscribe(result => {
      this.valorSaida = result
      console.log(this.valorSaida)
      this.openSnackBar(this.valorSaida > 0 ? 'Registro salvo' : 'Erro ao salvar registro', 'Fechar');
      this.dialogRef.close();
      this.formGroup.reset();
    });
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action);
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
