namespace ScreenSound_POO.Exercicios.modulo3
{
    internal class Pet
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Dono Dono { get; set; }
        public Pet(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void setDono(Dono dono)
        {
            Dono = dono;
        }


        public override string ToString()
        {
            return $"Nome: {Nome}, Idade:: {Idade}, Dono: {Dono.Nome}";
        }
    }
}
