using System;
using Enums;
namespace Entities{
    abstract class Proposta : IProposta
    {
        TipoOperacao tipoOperacao;
        public int situacao;
        public double valorParcela;

        public Proposta(TipoOperacao tipoOperacao,int situacao,double valorParcela){
            this.tipoOperacao=tipoOperacao;
            this.situacao=situacao;
            this.valorParcela=valorParcela;
        }

        public abstract double buscaValorParcela();
        public abstract int buscaSituacao();
    }
}