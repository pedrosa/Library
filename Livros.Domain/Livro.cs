﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Domain
{
    public sealed class Livro
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Isbn{ get; set; }
        public DateTime Datacriacao { get; init; }
        public Autor Autor { get; set; }

        public Livro(long id, string nome, string isbn, Autor autor)
        {
            Id = id;
            Nome = nome;
            Isbn = isbn;
            Autor = autor;

            Datacriacao = DateTime.Now;
        }
    }
}
