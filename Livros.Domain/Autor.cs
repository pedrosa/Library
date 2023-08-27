﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Domain
{
    public sealed class Autor
    {
        public string Nome { get; set; }

        public string Email { get; set;}

        public Autor(string nome)
        {
            Nome = nome;
        }
    }
}
