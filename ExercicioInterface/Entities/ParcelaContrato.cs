using System;
namespace Entities{
    class ParcelaContrato{
        double valorParcela {get;set;}
        DateTime dataPagamento{get;set;}
        public ParcelaContrato(DateTime dataPagamento){            
            this.dataPagamento=dataPagamento;
        }
        public void defineValorParcela(double valor){
            valorParcela=valor;
        }
        public override string ToString(){
            return dataPagamento.ToShortDateString() + " - " + valorParcela;
        }
    }
}