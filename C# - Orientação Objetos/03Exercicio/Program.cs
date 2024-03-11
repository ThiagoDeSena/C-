using System;

namespace _03Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.nome = "Denis";
            a.nota1 = 8;
            a.nota2 = 1;
            a.mensagem();
        }
    }
}