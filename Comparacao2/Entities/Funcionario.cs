using System;
namespace Entities{
    class Funcionario:IComparable{
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(string csvFuncionario){
            string[] vet=csvFuncionario.Split(',');
            Nome=vet[0];
            Salario=double.Parse(vet[1]);
        }
        public override string ToString(){
            return Nome + ", " + Salario;
        }
        public int CompareTo(object obj){
            if(!(obj is Funcionario)){
                throw new ArgumentException("erro de comparaçao");
            }
            Funcionario func = obj as Funcionario;
            return Nome.CompareTo(func.Nome);
        }
    }
}