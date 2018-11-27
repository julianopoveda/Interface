using System;
using System.Collections.Generic;
namespace Entities{
    class Contrato{
        int numero{get;set;}
        DateTime data { get; set; }
        public double valorTotal{get;set;}
        List<ParcelaContrato> listaParcelas{get;}

        public Contrato(int numero,DateTime data,double valorTotal){
            this.numero=numero;
            this.data=data;
            this.valorTotal=valorTotal;
            listaParcelas=new List<ParcelaContrato>();
        }
        public void adicionaParcelas(int quantidadeParcelas){
            int aux=1;
            while(aux<=quantidadeParcelas){
                listaParcelas.Add(new ParcelaContrato(data.AddMonths(aux)));
                aux++;
            }
        }
        public void defineValorParcela(double valor){
            foreach(ParcelaContrato parcela in listaParcelas){
                parcela.defineValorParcela(valor);
            }
        }
        public List<ParcelaContrato> retornaListaParcelas(){
            return listaParcelas;
        }
    }
}