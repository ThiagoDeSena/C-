using System;

class Aluno
{
    public string nome;
    public double nota1,nota2;

    public double media()
    {
        return (nota1+nota2)/2;
    }

    public string situacao(double media)
    {
        return media >= 7 ? "aprovado":"reprovado";   
    }

    public string situacao()
        {
            return situacao(media());
        }

    public void mensagem()
    {
        double obterMedia = media();

        string obtersituacao = situacao(obterMedia);

        Console.WriteLine(nome + " está " + obtersituacao+" com média "+obterMedia);
    }
}