using System;
using static System.Console;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int sorteio = 0;
            int number = 0 ;
            number = int.Parse(ReadLine());
            while (sorteio != number){
            Random randNum = new Random();
            sorteio = randNum.Next(0,10);
            WriteLine($"Resultado do sorteio {sorteio}");
            number = int.Parse(ReadLine());
            }
        }  

    }
}
