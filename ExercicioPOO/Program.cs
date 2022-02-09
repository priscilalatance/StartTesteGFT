using System;
using ExercicioPOO.src.Entities;

namespace ExercicioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Guerreiro guerreiro = new Guerreiro("Harry Potter", 2 , 7 , 3, 4, 5, 6);
            Mago mago = new Mago("Hermione Granger", 2 , 7 , 3, 4, 5, 6);
            mago.lvlUp();
            mago.attack();
            mago.aprenderMagia("Feitiço");

            guerreiro.lvlUp();
            guerreiro.attack();
            guerreiro.aprenderHabilidade("Poder");

        }
    }
}
