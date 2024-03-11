
using System;

class Pessoa
{

    public void apresentar()
    {
        Console.WriteLine("Olá");
    }

    public void apresentar(string name)
    {
        Console.WriteLine("Olá "+name);
    }

    public void apresentar(string name,int age)
    {
        Console.WriteLine("Olá "+name+" voçê tem "+age+" anos");
    }

}