using BemPromotoraCurso.Model.Entities;

namespace Entities
{

    public interface IProposta
    {
        decimal CorrigirValor();
        void AtualizarValorParcela(decimal novoValor);
        decimal ObterValorCorrigido();
    }

    public interface IRelatorio{
        Resumo GerarResumo();

    }
}