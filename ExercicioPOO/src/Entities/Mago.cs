using System;
using System.Collections.Generic;
using static System.Console;

namespace ExercicioPOO.src.Entities
{
    public class Mago : Personagem
    {
        public List<String>Magia{ get; set; }

        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base (nome, vida, mana, xp, inteligencia, forca, level){
            
        }
        public override void lvlUp()
        {
            WriteLine("Ao subir de nivel, aumentou sua Inteligencia e Mana");
        }
        public double attack(){
            Random randNum = new Random();
            int number = randNum.Next(180);
            return (Inteligencia / 2 * Math.Pow(Level,2))+ number;
        }

        public void aprenderMagia(String magia){
            WriteLine($"Voce subiu para {magia} de Magia");
        }
    }
}