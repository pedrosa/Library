namespace Livros.Services;

public sealed class ScreenService
{
    public void MainMenu()
    {
        var operacoes = new Operacoes();

        MenuOptions();

        void MenuOptions()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Menu de Livros");
            Console.WriteLine("2 - Menu de Autores");

            var op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                {
                    return;
                }
                case 2:
                {
                    MenuAutorOptions(operacoes);
                    break;
                }
                case 3:
                {
                    return;
                }
            }
        }
    }

    private static void MenuAutorOptions(Operacoes operacoes)
    {
        Console.WriteLine("Informe a opção desejada:");
        Console.WriteLine("1 - Cadastrar Autor");
        Console.WriteLine("2 - Alterar Autor");
        Console.WriteLine("3 - Lista de Autores");
        Console.WriteLine("4 - Sair ");

        var op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
            {
                CadastraAutor();
                break;
            }
            case 2:
            {
                AlteraAutor();
                break;
            }
            case 3:
            {
                ListaAutor();
                break;
            }
            case 4:
            {
                return;
            }
        }

        void CadastraAutor()
        {
            Console.WriteLine("Informe o nome do autor");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe o e-mail do autor");
            var email = Console.ReadLine();
            operacoes.CadastraAutor(nome, email);

            Thread.Sleep(300);
            Console.WriteLine("Cadastro realizado com sucesso!");
            MenuAutorOptions(operacoes);
        }

        void AlteraAutor()
        {
            throw new NotImplementedException();
        }

        void ListaAutor()
        {
            operacoes.ListaAutor();
            Thread.Sleep(300);
            MenuAutorOptions(operacoes);
        }
    }
}