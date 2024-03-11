using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.altura = 1.87f;
            pessoa.peso = 72f;

            Console.WriteLine(pessoa.retonarImc());
        }
    }
}