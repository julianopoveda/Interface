using System;
using System.IO;
using System.Collections.Generic;

namespace Comparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string caminho=@"C:\Users\caio\Desktop\Nomes.txt";
            try{
                using(StreamReader sr = File.OpenText(caminho)){
                List<string> lista=new List<string>();
                while(!sr.EndOfStream){
                    lista.Add(sr.ReadLine());
                }
                lista.Sort();
                foreach(string str in lista){
                    System.Console.WriteLine(str);
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
