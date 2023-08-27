﻿/*
 * 
 * // Linq C# https://learn.microsoft.com/en-us/dotnet/csharp/linq/
 */

using Livros.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Repository
{
    public sealed class AutorRepository
    {
        private List<Autor> _autores;

        public AutorRepository()
        {
            _autores = new List<Autor>();
        }

        public void Adicionar(Autor autor)
        {
            _autores.Add(autor);
        }

        public List<Autor> ObterTudo()
        {
            return _autores;
        }

        public void Atualizar(Autor autor)
        {
            var autorAtual = Obter(autor.Nome);

            if(autorAtual != null)
            {
                autorAtual.Email = autor.Email;
            }
        }

        public Autor Obter(string nome)
        {
            var autor = _autores.SingleOrDefault(s => s.Nome == nome); // Linq -> Single Where Firt Last Sum Min Max Average (AVG)

            return autor;
        }

        /*
        public Autor Obter(string nome)
        {
            for (int index = 0; index < _autores.Count; index++)
            {
                if (_autores[index].Nome == nome) // Match =
                {
                    return _autores[index];
                }

            }
            throw new Exception("Autor nao localizado");
        }
        */
    }
}
