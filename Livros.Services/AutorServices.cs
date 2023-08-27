using Livros.Domain;
using Livros.Repository;
using Livros.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros.Services
{
    public class AutorServices : IAutorServices
    {
        private AutorRepository _autorRepository;

        public AutorServices()
        {
            _autorRepository = new AutorRepository();   
        }

        public void Alterar(Autor autor)
        {
            _autorRepository.Atualizar(autor);
        }

        public void Cadastrar(Autor autor)
        {
            _autorRepository.Adicionar(autor);
        }

        public Autor Obter(string nome)
        {
            return _autorRepository.Obter(nome);
        }

        public List<Autor> ListaAutor()
        {
            return _autorRepository.ObterTudo();
        }
    }
}
