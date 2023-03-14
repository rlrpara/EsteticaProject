import { Component, OnInit } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';

import { TipoPessoa } from '../../../shared/models/tipoPessoa';
import { TipoEndereco } from '../../../TipoEndereco/model/TipoEndereco';
import { TipoenderecoService } from '../../../TipoEndereco/services/tipoendereco.service';
import { FiltroTipoPessoa } from '../../../TipoPessoa/model/filtroTipoPessoa';
import { TipopessoaService } from '../../../TipoPessoa/services/tipopessoa.service';
import { ClienteService } from '../../services/cliente.service';

@Component({
  selector: 'app-cliente-dialog',
  templateUrl: './cliente-dialog.component.html',
  styleUrls: ['./cliente-dialog.component.scss']
})
export class ClienteDialogComponent implements OnInit {

  private filtroTipoPessoa!: FiltroTipoPessoa;
  valorSaida: number = 0;

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
  ) {
    this.filtroTipoPessoa = {
      descricao: ''
    }

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

  public cancel(): void {
    this.dialogRef.close();
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 1000
    });
  }
}
