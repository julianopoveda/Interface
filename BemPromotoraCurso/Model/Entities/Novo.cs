using Entities;
using Enums;

namespace BemPromotoraCurso.Model.Entities
{
    public class Novo : Proposta, IProposta
    {        
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
            decimal fatorial = 1M;
            decimal valor = ValorParcela;

            while (valor > 0)
            {
                fatorial = fatorial * valor;
                valor--;
            }
            
            return fatorial;
        }

        public decimal ObterValorCorrigido()
        {
            return ValorTotal;
        }
    }
}