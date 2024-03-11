using System.Text.RegularExpressions;
using System;

class Pessoa
{
    public float peso;
    public float altura;

    public double imc()
    {
        return peso / (altura*altura);
    }
    public string retonarImc()
    {
        if(imc() < 18.5){
            return "Abaixo do peso";
        }else if(imc() < 25){
            return "Peso normal";
        }else if(imc() < 30){
            return "Acima do peso";
        }else if(imc() < 35){
            return "Obesidade I";
        }else if(imc() < 40){
            return "Obesidade II";
        }else{
            return "Obesidade III";
        }
    }
}