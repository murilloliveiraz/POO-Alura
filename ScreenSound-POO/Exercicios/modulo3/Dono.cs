namespace ScreenSound_POO.Exercicios.modulo3
{
    internal class Dono
    {
        public string Nome { get; set; }
        public Pet Pet { get; set; }

        public Dono(string nome)
        {
            Nome = nome;
        }

        public void setPet(Pet pet)
        {
            Pet = pet;
            // Estabelece a relação bidirecional, definindo o dono deste pet como o dono atual
            if (pet != null)
            {
                pet.setDono(this);
            }
        }
    }
}
