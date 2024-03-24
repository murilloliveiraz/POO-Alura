using ScreenSound.Models;

namespace ScreenSound_POO.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
