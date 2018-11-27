using System;

namespace Services{
    class PayPal : IServicoPagamento
    {
        public double valorPagamentoMensalJurosSimples(double valor)
        {
            return valor+=(valor*0.01);
        }

        public double valorPagamentoMensalJurosComposto(double valor)
        {
            return valor+=(valor*0.02);
        }
    }
}