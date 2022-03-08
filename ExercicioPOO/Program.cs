using System;
using System.Collections.Generic;
using ExercicioPOO.src.Entities;

namespace ExercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro("Harry Potter", 2 , 7 , 3, 4, 5, 6);
            Mago mago = new Mago("Hermione Granger", 2 , 7 , 3, 4, 5, 6);
            List<Mago> magoLista = new List<Mago>();
            List<Guerreiro> guerreiroLista = new List<Guerreiro>();
            magoLista.Add(mago);
            guerreiroLista.Add(guerreiro);

            Console.WriteLine("Bem Vindo ao RPG!");
            Console.WriteLine("Escolha umas das opções de Jogador:\n1 - Mago.\n2 - Guerreiro");
            int jogador = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha umas das opções do Jogo referente o Mago:\n3 - Ataque.\n4 - Aumentar o Nível.");
            Console.WriteLine("Escolha umas das opções do Jogo referente o Guerreiro:\n6 - Ataque.\n7 - Aumentar o Nível.\nX - Sair");
            string opcao = Console.ReadLine();            


            while(opcao.ToUpper() != "X")
            {
                switch(opcao)
                {
                    case "3":
                        Console.WriteLine(mago.attack()); 
                    break;
                    case "4":
                         mago.lvlUp();
                    break;
                    case "5":
                         Console.WriteLine(guerreiro.attack());
                    break;
                    case "6":
                         Console.WriteLine(guerreiro.attack());
                    break;
                    case "7":
                        guerreiro.lvlUp();
                    break;
                }
                opcao = Console.ReadLine();  
            }

        }
    }
}
