using System;
using Entities;
using Enums;

namespace BemPromotoraCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            IProposta proposta=new Portabilidade("124214121",TipoOperacao.Portabilidade,3,150);
            Console.WriteLine(proposta.ToString());
        }
    }
}
