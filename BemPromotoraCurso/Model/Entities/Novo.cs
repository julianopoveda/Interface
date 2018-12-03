using Entities;
using Enums;

namespace BemPromotoraCurso.Model.Entities
{
    public class Novo : Proposta, IProposta
    {
        public decimal ValorParcela { get; set; }

        public Novo(decimal valorParcela)
        {
            ValorParcela = valorParcela;
            DefinirTipoOperacao(TipoOperacao.Novo);
            Situacao = 3;
            ValorTotal = CorrigirValor();
        }

        public void AtualizarValorParcela(decimal novoValor)
        {
            ValorParcela = novoValor;
        }

        public decimal CorrigirValor()
        {
            decimal fatorial = 1;
            decimal valor = ValorParcela;

            while (valor > 0)
            {
                fatorial = fatorial * valor;
                valor--;
            }
        }

        public decimal ObterValorCorrigido()
        {
            return ValorTotal;
        }
    }
}