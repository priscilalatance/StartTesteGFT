using System;

namespace ExercicioPOO.src.Entities
{
    public abstract class Personagem
    {
        private string nome;
        private int vida;
        private int mana;
        private float xp;
        private int inteligencia;
        private int forca;
        private int level;

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level){
            this.nome = nome;
            this.vida = vida;
            this.mana = mana;
            this.xp = xp;
            this.inteligencia = inteligencia;
            this.forca = forca;
            this.level = level;
        }
        public abstract void lvlUp();
        public string Nome { get => nome; set => nome = value; }
        public int Vida { get => vida; set => vida = value; }
        public int Mana { get => mana; set => mana = value; }
        public float Xp { get => xp; set => xp = value; }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public int Forca { get => forca; set => forca = value; }
        public int Level { get => level; set => level = value; }

    }
}