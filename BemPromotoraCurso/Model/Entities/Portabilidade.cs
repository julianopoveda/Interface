using System;
using Enums;
namespace Entities{
    class Portabilidade : Proposta
    {
        string ifOriginadora;
        public Portabilidade(string ifOriginadora,TipoOperacao tipoOperacao,
            int situacao,double valorParcela):base(tipoOperacao,situacao,valorParcela){
            this.ifOriginadora=ifOriginadora;
        }
        public override double buscaValorParcela()
        {
            return valorParcela;
        }

        public override int buscaSituacao()
        {
            return situacao;
        }
        public string buscaIfOriginadora(){
            return ifOriginadora;
        }
        public override string ToString(){
            return "Valor Parcela: " + buscaValorParcela()
                + "\nIF Originadora: " + buscaIfOriginadora()
                + "\nSituação: " + buscaSituacao();
        }
    }
}