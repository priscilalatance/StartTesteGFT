using System;
using System.Collections.Generic;

namespace Exercicio3.src.Entities
{
    public class Leitor
    {
        private string nome;
        private Livro livroFavorito;
        private List<Livro> estanteLivros;

        public Leitor(string nome, Livro livroFavorito)
        {
            this.nome = nome;
            this.livroFavorito = livroFavorito;
            this.estanteLivros = new List<Livro>();
            this.estanteLivros.Add(livroFavorito);
        }

        public void adicionarLivro(Livro livro)
        {
            this.estanteLivros.Add(livro);
        }

        public void removerLivro(Livro livro)
        {
            livro.zerarPaginasLidas();
            this.estanteLivros.Remove(livro);
        }

        public int quantidadeLivrosEstante()
        {
            return estanteLivros.Count;
        }
    }
}