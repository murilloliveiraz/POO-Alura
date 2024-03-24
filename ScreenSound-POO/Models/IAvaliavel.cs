using ScreenSound.Models;

namespace ScreenSound_POO.Models
{
    internal interface IAvaliavel
    {
        void AdicionarNota(Avaliacao nota);
        double Media { get; }
    }
}
