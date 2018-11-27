using System;
using Entities;
using Services;
using System.Globalization;
namespace ExercicioInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Digite os dados do contrato----");
            Console.Write("Número: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime dataContrato = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Valor Total do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine());
            Contrato contrato = new Contrato(numeroContrato,dataContrato,valorContrato);
            Console.Write("Digite o número de parcelas desejadas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Cobranca cobranca=new Cobranca(new PayPal());
            cobranca.defineQuantidadeParcelas(contrato,numeroParcelas);
            cobranca.defineValorParcelas(contrato);

            Console.WriteLine("----Parcelas-----");
            foreach(ParcelaContrato detalhesParcelas in contrato.retornaListaParcelas()){
                Console.WriteLine(detalhesParcelas.ToString());
            }
            
        }
    }
}
