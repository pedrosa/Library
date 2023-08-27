using Livros.Services;

class Program
{
    static void Main(string[] args)
    {
        ScreenService screenService = new ScreenService();
        
        screenService.MainMenu();
    }
    
}