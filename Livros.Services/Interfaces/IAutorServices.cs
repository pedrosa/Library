using Livros.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Services.Interfaces
{
    public interface IAutorServices
    {
        public void Cadastrar(Autor autor);
        public void Alterar(Autor autor);
        public Autor Obter(string nome);
        public List<Autor> ListaAutor();
    }
}
