namespace Admin.Filme;
class Artista
{
    public string nome { get; set; }
    public int idade { get; set; }
    public List<Filme> filmesQueAtuou { get; set; }

    public Artista(string nome, int idade)
    {
        this.nome = nome;
        this.idade = idade;
        filmesQueAtuou = new List<Filme>();
    }

    public void adicionarFilme(Filme filme)
    {
        filmesQueAtuou.Add(filme);
        if (!filme.Elenco.Contains(this)) filme.adicionarElenco(this);
    }

    public void mostrarFilmes()
    {
        foreach(var filme in filmesQueAtuou)
        {
            Console.Write(filme.Titulo);
        }
    }
}