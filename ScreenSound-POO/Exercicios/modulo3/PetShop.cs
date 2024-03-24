namespace ScreenSound_POO.Exercicios.modulo3
{
    internal class PetShop
    {
        public string Nome { get; set; }
        public Medico Medico { get; set; }

        public PetShop(string nome, Medico medico)
        {
            Nome = nome;
            Medico = medico;
        }

        public void MarcarConsulta(Pet pet)
        {
            Consulta consulta = new(pet, Medico);
            Console.WriteLine($"O pet {pet.Nome} tem uma consulta marcada com o {Medico.Nome}, no petshop: {Nome}");
            consulta.dadosDoPaciente();
        }
    }
}

/**
 using ScreenSound_POO.Exercicios.modulo3;

PetShop petShop = new("Pet da vila", new Medico("Murillo Oliveira"));
Dono marcos = new("Marcos");
Pet pug = new Pet("Sakura", 14);
pug.setDono(marcos);
marcos.setPet(pug);

petShop.MarcarConsulta(pug);**/