using System;
using BemPromotoraCurso.Model.Entities;
using Enums;

namespace Entities
{
    public class Proposta
    {
        TipoOperacao TipoOperacao;
        public int Situacao;
        protected double ValorParcela;
        public decimal ValorTotal { get; set; }

        public Proposta() { }

        public Proposta(TipoOperacao tipoOperacao, int situacao, double valorParcela, decimal valorTotal = 0)
        {
            tipoOperacao = tipoOperacao;
            Situacao = situacao;
            ValorParcela = valorParcela;
            ValorTotal = valorTotal;
        }

        public string QualOTipoOperacao()
        {
            return TipoOperacao.ToString();
        }

        protected void DefinirTipoOperacao(TipoOperacao tipoOperacao)
        {
            TipoOperacao = tipoOperacao;
        }
    }
}