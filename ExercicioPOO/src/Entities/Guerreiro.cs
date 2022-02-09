using System;
using System.Collections.Generic;
using static System.Console;

namespace ExercicioPOO.src.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string>Habilidade { get; set; }
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base (nome, vida, mana, xp, inteligencia, forca, level){
            
        } 
        public override void lvlUp()
        {
            WriteLine("Ao subir de nivel, aumentou sua Vida e Força!");
        }    
        public double attack(){
            Random randNum = new Random();
            int number = randNum.Next(180);
            return (Forca / 2 * Math.Pow(Level,2))+ number;
        }

        public void aprenderHabilidade(string habilidade){
            WriteLine($"Voce subiu para {habilidade} de habilidade");

        } 
    }
}