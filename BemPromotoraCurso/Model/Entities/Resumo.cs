using System;
using System.Collections.Generic;
using Enums;

namespace BemPromotoraCurso.Model.Entities
{
    public class Resumo
    {
        public const string versao = "3.1.0";

        private DateTime _primeiroVencimento;

        public decimal ValorTotal { get; set; }

        public string TipoOperacao { get; set; }

        public string Observacao { get; set; } = string.Empty;

        public bool Viavel { get; set; }

        public DateTime PrimeiroVencimento
        {
            get { return _primeiroVencimento; }
            set { _primeiroVencimento = value; }
        }

        public List<decimal> Indices { get; set; }

        public Resumo() { }

        public Resumo(decimal valorTotal, TipoOperacao tipoOperacao, string observacao, DateTime primeiroVencimento, bool viavel = false)
        {
            ValorTotal = valorTotal;
            TipoOperacao = tipoOperacao.ToString();
            Observacao = observacao;
            PrimeiroVencimento = primeiroVencimento;
            Viavel = viavel;
        }

        #region Métodos
        public float RetornarIndicesAcumulado()
        {
            float indiceAcumulado = 0;
            foreach (float indice in Indices)
                indiceAcumulado += indice;

            return indiceAcumulado;
        }
        #endregion
    }
}