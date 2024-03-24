namespace ScreenSound_POO.Exercicios.modulo7
{
    internal class Veiculo : IPilotavel, IVoavel
    {
        public void Pilotar()
        {
            Console.WriteLine("Veiculo está pilotando");
        }

        public void Voar()
        {
            Console.WriteLine("Veiculo esta Voando");
        }
    }
}
