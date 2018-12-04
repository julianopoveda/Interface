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
                new Novo(12M),
                new Portabilidade(3, 325.72M)
            };

            foreach (Proposta proposta in propostas)
            {                
                Console.WriteLine($"Meu tipo de operacao é: {proposta.QualOTipoOperacao()}");
                Console.WriteLine($"Meu valor corrigido é: {((IProposta)proposta).CorrigirValor()}");
            }
            
            IProposta propostaNovo = (IProposta)propostas[0];
            Console.WriteLine($"Valor Total = {propostaNovo.ObterValorCorrigido()}");
            propostaNovo.AtualizarValorParcela(6M);
            Console.WriteLine($"Após atualizar o valor da parcela para 6 o novo total é = {propostaNovo.CorrigirValor()}");

            IRelatorio relatorio = (IRelatorio)propostas[1];
            Resumo resumo = relatorio.GerarResumo();
            Console.WriteLine(string.Format("Operação de {0} é viável? {1}", resumo.TipoOperacao, resumo.Viavel));

            Console.ReadLine();
        }
    }
}
