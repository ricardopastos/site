using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alunosnotas
{
    class Program
    {// Utilizando estrutura de repetição, crie um programa que leia 5 notas de um aluno, calcule e mostre a média das notas.
        static void Main(string[] args)
        {
            int i; //contador
            double nota = 0, somadasnotas = 0, mediadasnotas = 0;

            //laços de repetição para ler as 5 notas
            for (i = 1; i<=5; i++)
            {
                Console.WriteLine("Informe a [{0}ª] nota: ", i);
                nota = double.Parse(Console.ReadLine());

                somadasnotas = somadasnotas + nota;
                mediadasnotas = somadasnotas / 5;
             }
            //calcula a media das notas
            Console.WriteLine("\nA soma das notas é: " + somadasnotas);
            Console.WriteLine("\nA média das notas é: " + mediadasnotas);
            Console.ReadKey();
        }
    }
}