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
            int situacao, decimal valorParcela) : base(TipoOperacao.Portabilidade, situacao, valorParcela)
        {
            _indices = new List<decimal>
            {
                0.64M, 0.08M, 0.01M, -1.1M, -0.93M, -0.67M, -0.72M,
                0.10M, 0.47M, 0.20M, 0.52M, 0.89M, 0.76M, 0.07M, 0.64M,
                0.57M, 1.38M, 1.87M, 0.51M, 0.70M, 1.52M, 0.89M, -0.49M
            };
        }

        public decimal CorrigirValor()
        {
            decimal indiceAcumulado = 1M;

            for (int i = 0; i < _indices.Count; i++)
            {
                decimal indiceEmDecimal = _indices[i] / 100;
                indiceAcumulado += indiceAcumulado * (1 + indiceEmDecimal);
            }

            return indiceAcumulado * ValorParcela;
        }

        public Resumo GerarResumo()
        {
            return new Resumo(ValorTotal, TipoOperacao.Portabilidade, "observacao", DateTime.Now, ValorTotal > 1000);
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