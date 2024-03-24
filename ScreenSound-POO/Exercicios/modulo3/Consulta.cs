namespace ScreenSound_POO.Exercicios.modulo3
{
    internal class Consulta
    {
        public Pet Pet { get; set; }
        public Medico Medico { get; set; }

        public Consulta(Pet pet, Medico medico)
        {
            Pet = pet;
            Medico = medico;
        }

        public void dadosDoPaciente()
        {
            Console.WriteLine(Pet);
        }
    }
}
