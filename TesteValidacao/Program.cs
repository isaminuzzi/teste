using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteValidacao
{
//    Utilizando listas, faça um programa que faça 5 perguntas para uma

//pessoa sobre um crime.As perguntas são:



//○ “Telefonou para a vítima?”

//○ “Esteve no local do crime?”

//○ “Mora perto da vítima?”

//○ “Devia para a vítima?”

//○ “Já trabalhou com a vítima?”



//● Se a pessoa responder positivamente a 2 questões ela deve ser

//classificada como “Suspeita”, entre 3 e 4 como “Cúmplice” e 5 como

//“Assassino”. Caso contrário, ele será classificado como “Inocente”.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE VERIFICA SE VOCE É UM ASSASSINO\n");
            Console.WriteLine("Respostas: 'sim' e 'nao'");
            List<string>  respostas  = new List<string>();
            Console.WriteLine("Telefonou para a vítima?");
            respostas.Add(Console.ReadLine());
            Console.WriteLine("Esteve no local do crime?");
            respostas.Add(Console.ReadLine());
            Console.WriteLine("Mora perto da vítima?");
            respostas.Add(Console.ReadLine());
            Console.WriteLine("Devia para a vítima?");
            respostas.Add(Console.ReadLine());
            Console.WriteLine("Já trabalhou com a vítima?");
            respostas.Add(Console.ReadLine());

            int count = respostas.Count(x => x.Equals("sim"));

            if (count <= 1) Console.WriteLine("Você é inocente!");
            if (count == 2) Console.WriteLine("Você é um suspeito!");
            if (count == 3 || count == 4) Console.WriteLine("Você é cúmplice!");
            if (count == 5) Console.WriteLine("Você é o assassino!");
    

        }
    }
}
