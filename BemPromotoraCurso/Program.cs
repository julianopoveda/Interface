using System;
using System.Collections.Generic;
using BemPromotoraCurso.Model.Entities;
using Entities;
using Enums;

namespace BemPromotoraCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Proposta> propostas = new List<Proposta>{
                new Novo(123.50M),
                new Portabilidade(3, 325.72)
            };

            IProposta proposta = propostas[0];
            Console.WriteLine($"Valor Total = {proposta.ObterValorCorrigido()}");
            proposta.AtualizarValorParcela(32);
            Console.WriteLine($"Após atualizar o valor da parcela para 32 o novo total é = {proposta.CorrigirValor()}");

            foreach (Proposta proposta in propostas)
            {
                Console.WriteLine($"Meu tipo de operacao é: {proposta.QualOTipoOperacao()}");
                Console.WriteLine($"Meu valor corrigido é: {((IProposta)proposta).CorrigirValor()}");
            }

            IRelatorio relatorio = proposta[1];
            Console.WriteLine(relatorio.GerarResumo());

            Console.WriteLine(proposta.ToString());
        }
    }
}
