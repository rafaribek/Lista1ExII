using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ExII
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
    public class Aluno : Pessoa
    {
        private double nota;

        public double Nota
        {
            get { return nota; }
            set
            {
                if (value > 0 && value <= 10)
                {
                    nota = value;
                }
                else
                {
                    throw new ArgumentException("A nota não pode ser menor que 0 ou maior que 10");
                }
            }
        }

        public Aluno(string Nome, int Idade, double Nota) : base(Nome, Idade)
        {
            this.Nota = Nota;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Aluno aluno = new Aluno("Rafael", 19, 10);
                Console.WriteLine("Aluno: " + aluno.Nome);
                Console.WriteLine("Idade: " + aluno.Idade);
                Console.WriteLine("Nota: " + aluno.Nota);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
