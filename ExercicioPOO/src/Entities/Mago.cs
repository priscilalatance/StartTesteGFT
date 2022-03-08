using System;
using System.Collections.Generic;
using static System.Console;

namespace ExercicioPOO.src.Entities
{
    public class Mago : Personagem
    {
        private List<string> magia;
        public List<string> Magia {get => magia; set => magia = value;} 

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base (nome, vida, mana, xp, inteligencia, forca, level){


        }
        public override void lvlUp()
        {
            Level += 1;
            Mana += 1;
            Inteligencia += 1;
            Console.WriteLine($"O Level do Mago aumentou de nível, aumentando seu mana para {Mana} e inteligência para {Inteligencia}.");
        }
        public double attack(){
            Random randNum = new Random();
            int number = randNum.Next(0, 180);
            return (Inteligencia / 2 * Math.Pow(Level, 2))+ number;
        }

        public void aprenderMagia(String nomeMagia){
            Magia.Add(nomeMagia);
        }
    }
}