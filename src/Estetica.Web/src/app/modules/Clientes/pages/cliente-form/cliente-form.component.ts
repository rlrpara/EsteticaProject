import { FormBuilder, FormGroup } from '@angular/forms';
import { Component } from '@angular/core';

@Component({
  selector: 'app-cliente-form',
  templateUrl: './cliente-form.component.html',
  styleUrls: ['./cliente-form.component.scss']
})
export class ClienteFormComponent {

  form!: FormGroup;

  constructor (
    private _formBuilder: FormBuilder
  ) {
    this.criarForm(_formBuilder);
  }

  criarForm(formBuilder: FormBuilder) {
    this.form = formBuilder.group({
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

  onFormSubmit() {
    if (this.form.valid) {
      console.log(this.form.value);
    }
  };

  public Salvar(): void {
    if (this.form.invalid) return;
  }
}
