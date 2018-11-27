namespace Services{
    interface IServicoPagamento{
        double valorPagamentoMensalJurosSimples(double valor);
        double valorPagamentoMensalJurosComposto(double valor);
    }
}