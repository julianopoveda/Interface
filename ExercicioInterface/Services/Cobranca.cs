using System;
using System.Collections.Generic;
using Entities;
namespace Services{
    class Cobranca{
        IServicoPagamento servicoPagamento;

        public Cobranca(IServicoPagamento servicoPagamento){
            this.servicoPagamento=servicoPagamento;
        }
        public void defineQuantidadeParcelas(Contrato contrato,int numeroParcelas){
            contrato.adicionaParcelas(numeroParcelas);
        }
        public void defineValorParcelas(Contrato contrato){
            
            int numeroParcelas=contrato.retornaListaParcelas().Count;
            double valorTotal=contrato.valorTotal;
            double valorBaseParcela=(valorTotal/numeroParcelas);
            double valorFinalParcela=(servicoPagamento.valorPagamentoMensalJurosComposto(valorBaseParcela)
                *numeroParcelas);          
            contrato.defineValorParcela(valorBaseParcela);  
                        
        }
        
    }
}