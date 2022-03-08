using System;
using System.Collections.Generic;
using static System.Console;

namespace ExercicioPOO.src.Entities
{
    public class Guerreiro : Personagem
    {
        public List<string> Habilidade { get; set; }
        
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base (nome, vida, mana, xp, inteligencia, forca, level){
            
        } 
        public override void lvlUp()
        {
            Level += 1;
            Vida += 1;
            Forca += 1;
            Console.WriteLine($"O Level do Gerreiro aumentou de nível, aumentando sua força para {Forca} e vida para {Vida}.");
        }    
        public double attack(){
            Random randNum = new Random();
            int number = randNum.Next(0,180);
            return (Forca / 2 * Math.Pow(Level,2))+ number;
        }

        public void aprenderHabilidade(string habilidade){
           Habilidade.Add(habilidade);

        } 
    }
}