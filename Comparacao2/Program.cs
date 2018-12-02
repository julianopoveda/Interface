using System;
using Entities;
using System.IO;
using System.Collections.Generic;

namespace Comparacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho=@"C:\Users\caio\Desktop\Nomes.txt";
            try{
                using(StreamReader sr = File.OpenText(caminho)){
                List<Funcionario> lista=new List<Funcionario>();
                while(!sr.EndOfStream){
                    lista.Add(new Funcionario(sr.ReadLine()));
                }
                lista.Sort();
                foreach(Funcionario funcionario in lista){
                    System.Console.WriteLine(funcionario);
                }
              }
            }
            catch(IOException ex){
                System.Console.WriteLine("Um erro ocorreu");
                System.Console.WriteLine(ex.Message);
            }
        }        
    }
}
