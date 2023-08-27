using Livros.Domain;
using Livros.Services;
using Livros.Services.Interfaces;

namespace Livros
{
    public sealed class Operacoes
    {
        private IAutorServices _autorServices;
        private ILivroServices _livroServices;

        public Operacoes()
        {
            _autorServices = new AutorServices();
            _livroServices = new LivroServices();
        }

        public void CadastraAutor(string nome, string email)
        {
            var autor = new Autor(nome)
            {
                Nome = nome,
                Email = email
            };

            _autorServices.Cadastrar(autor);
        }

        public void CadastrarLivro(long id, string nomeLivro, string Descricao, string isbn, string nomeAutor,
            string email)
        {
            var autor = _autorServices.Obter(nomeAutor);

            if (autor == null)
            {
                autor = new Autor(nomeAutor)
                {
                    Email = email
                };
            }

            var livro = new Livro(id, nomeLivro, isbn, autor);


            _livroServices.Cadastrar(livro);
        }

        public void AlterarAutor(Autor autor)
        {
            _autorServices.Alterar(autor);
        }

        public void AlterarLivro(Livro livro)
        {
            _livroServices.Alterar(livro);
        }

        public void ListaAutor()
        {
            List<Autor> listaAutores = _autorServices.ListaAutor();
            
            foreach (Autor autor in listaAutores)
            {
                Console.WriteLine($"Nome: {autor.Nome}, E-mail: {autor.Email}");
            }
        }
    }
}