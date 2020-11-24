using System;

namespace Atividade_revisão
{
    class Program
    {
        // - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
        // ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).
        static void Main(string[] args)
        {
           
           Console.WriteLine("Digite o ano atual: ");
           int anoAtual = int.Parse(Console.ReadLine());

           Console.WriteLine("Digite o seu ano de nascimento : ");
           int anoNascimento = int.Parse(Console.ReadLine());

           int idade = (anoAtual - anoNascimento);

           if(idade >= 16){
               Console.WriteLine("Você poderá votar este ano!");

           }else{
               Console.WriteLine("Você não poderá votar este ano!");

           }
        }
    }
}
