using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa obj = new Pessoa();

            obj.name = "Thiago";
            obj.age = 24;

            obj.mensagem();
        }
    }
    
}
