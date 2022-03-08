using System;

namespace Exercicio3.src.Entities
{
    public class Livro
    {
        private string titulo;
        private int qtdPaginas;
        private int paginasLidas;

        public Livro(string titulo, int qtdPaginas)
        {
            this.titulo = titulo;
            this.qtdPaginas = qtdPaginas;
            this.paginasLidas = 0;
        }

        public void zerarPaginasLidas()
        {
            paginasLidas = 0;
        }

        public double verificarProgresso()
        {
            return (paginasLidas / (double)qtdPaginas) * 100;
        }

        public int adicionarpaginasLidas()
        {
            paginasLidas++;
            return paginasLidas;
        }
    }
}