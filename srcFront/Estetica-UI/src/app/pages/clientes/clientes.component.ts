import { ClientesService } from './../../services/ClientesServices/clientes.service';
import { ClienteDialogComponent } from './../../shared/cliente-dialog/cliente-dialog.component';
import { Component, OnInit } from '@angular/core';
import ClientesModel from 'src/app/models/ClientesModels';
import { MatDialog } from '@angular/material/dialog';
import filtroClienteModels from 'src/app/models/filtroClienteModels';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css'],
  providers: [ClientesService]
})
export class ClientesComponent implements OnInit {

  clientes: ClientesModel[] = [{
    codigo: 1,
    nome: 'Clara Muniz',
    nascimento: new Date('1999-01-26'),
    cpf: '735.949.900-36',
    endereco: '',
    cidade: '',
    uf: '',
    cep: '',
    telefone: '',
    email: '',
    profissao: '',
    instagran: '',
    estadoCivilId: 0,
    numeroFilhos: 0,
    conheceuPeloFacebook: true,
    conheceuPeloInstagran: true,
    conheceuPelaInternet: true,
    indicacao: true,
    indicacaoQuem: '',
    conheceuOutros: true,
    conheceuOutrosQual: '',
    jaFezTratamentoEstetico: '',
    jaFezTratamentoEsteticoQual: '',
    areaInteresseEsculpeDetox: true,
    areaInteresseEsculpe21: true,
    spaFacial: true,
    spaCorporal: true,
    aparelhoAplicacaoAtivos: true,
    habitosAlimentaresFritura: true,
    habitosAlimentaresFruta: true,
    habitosAlimentaresFarinhaBranca: true,
    habitosAlimentaresSemente: true,
    habitosAlimentaresLeite: true,
    habitosAlimentaresLegume: true,
    habitosAlimentaresDerivadoLeite: true,
    habitosAlimentaresVerdura: true,
    habitosAlimentaresAcucar: true,
    habitosAlimentaresFarinhaIntegral: true,
    liquidoRefrigerante: true,
    liquidoBebidaAlcolica: true,
    liquidoSucoIndustrializado: true,
    liquidoCha: true,
    liquidoSucoNatural: true,
    liquidoChimarrao: true,
    liquidoAgua: true,
    liquidoAguaQuantidadeDiaria: 0,
    atividadeFisicaPraticaRegularmente: true,
    atividadeFisicaPraticaRegularmenteQuantasVezesSemana: 0,
    atividadeFisicaPraticaRegularmenteQuaisAtividades: '',
    atividadeFisicaNaoPratica: true,
    atividadeFisicaNuncaPraticou: true,
    sonoMenos6Horas: true,
    sono6Horas: true,
    sono8HorasOuMais: true,
    funcionamentoIntestinoTodosDias: true,
    funcionamentoIntestino3MaisSemana: true,
    funcionamentoIntestino1Semana: true,
    retencaoLiquido2Dia: true,
    retencaoLiquidoMais2Dia: true,
    retencaoLiquidoMais5Dia: true,
    metodoContraceptivoNenhum: true,
    metodoContraceptivoMirena: true,
    metodoContraceptivoPilula: true,
    metodoContraceptivoMenopausa: true,
    metodoContraceptivoAdesivo: true,
    metodoContraceptivoImplante: true,
    metodoContraceptivoDiu: true,
    metodoContraceptivoAlgumaCirurgia: '',
    acompanhamentoContinuoCardiologista: true,
    acompanhamentoContinuoDermatologista: true,
    acompanhamentoContinuoNutrologo: true,
    acompanhamentoContinuoPsicologo: true,
    acompanhamentoContinuoPsiquiatra: true,
    acompanhamentoContinuoCoach: true,
    acompanhamentoContinuoGinecologista: true,
    acompanhamentoContinuoPersonalTrainer: true,
    acompanhamentoContinuoTraumatologista: true,
    acompanhamentoContinuoNutricionista: true,
    medicamentoUsoContinuo: '',
    quantoTempoPesoIdeal: '',
    pesoAtual: 0,
    pesoIdeal: 0,
  }];

  filtroCliente: filtroClienteModels = {
    nome: ''
  }

  // parei 19:19
  // https://www.youtube.com/watch?v=LlmIF9wjqzE&list=PL2fQZkIXag6U_eGEbmnSQBSqFbGHRrBOn&index=5

  displayedColumns: string[] = ['codigo', 'nome', 'nascimento', 'cpf', 'acoes'];

  constructor(
    public dialog: MatDialog,
    public clientesService: ClientesService
  ) {
    this.clientesService.obterTodos(this.filtroCliente)
      .subscribe(data => {
        console.log(data);
        this.clientes = data;
      })
  }

  ngOnInit(): void {
  }

  openDialog(clientes: ClientesModel | null) {
    const dialogRef = this.dialog.open(ClienteDialogComponent, {
      width: '900px',
      data: clientes != null ?
        clientes : {
          codigo: 1,
          nome: '',
          nascimento: null,
          cpf: ''
        },
    });

    dialogRef.afterClosed().subscribe(result => {
      console.log('The dialog was closed');
    });
  }

  updateCliente(clientesModel: ClientesModel) {
    this.openDialog(clientesModel);
  }

  deleteCliente(codigo: number) {

  }
}
