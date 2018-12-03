using System;
using System.Collections.Generic;
using BemPromotoraCurso.Model.Entities;
using Enums;

namespace Entities
{
    class Portabilidade : Proposta, IProposta, IRelatorio
    {
        private List<decimal> _indices;

        public Portabilidade(
            int situacao, double valorParcela) : base(TipoOperacao.Portabilidade, situacao, valorParcela)
        {
            _indices = new List<decimal>
            {
                0.64,0.08,0.01,-1.10,-0.93,-0.67,-0.72,
                0.10,0.47,0.20,0.52,0.89,0.76,0.07,0.64,
                0.57,1.38,1.87,0.51,0.70,1.52,0.89,-0.49
            };
        }

        public override string ToString()
        {
            return "Valor Parcela: " + buscaValorParcela()
                + "\nIF Originadora: " + buscaIfOriginadora()
                + "\nSituação: " + buscaSituacao();
        }

        public decimal CorrigirValor()
        {
            decimal indiceAcumulado = 1;
            for (int i = 0; i < _indices.Count; i++)
            {
                decimal indiceEmDecimal = _indices[i] / 100;
                indiceAcumulado += indiceAcumulado * (1 + indiceEmDecimal);
            }

            return indiceAcumulado * ValorParcela;
        }

        public Resumo GerarResumo()
        {
            return new Resumo(ValorTotal, tipoOperacao, observacao, DateTime.Now, viavel);
        }

        public void AtualizarValorParcela(decimal novoValor)
        {
            if (novoValor > 0)
                ValorParcela = novoValor;
        }

        public decimal ObterValorCorrigido()
        {
            return ValorParcela;
        }
    }
}