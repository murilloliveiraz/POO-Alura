using ScreenSound_POO.Exercicios.modulo3;

namespace ScreenSound_POO.Exercicios.modulo4
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        public string Nome { get; set; }
        public Dono Dono { get; set; }

        public Veiculo(string nome, string placa)
        {
            Nome = nome;
            Placa = placa;
        }

        public void setDono(Dono dono)
        {
            Dono = dono;
        }
    }
}
