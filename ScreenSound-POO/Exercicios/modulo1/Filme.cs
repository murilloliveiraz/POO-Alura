using System.Linq.Expressions;

namespace Admin.Filme;

class Filme
{
    public string Titulo { get; set; }
    public double Duracao { get; set; }
    public List<Artista> Elenco { get; set; }

    public Filme(string titulo, double duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elenco = new List<Artista>();
        }
        else
        {
            Elenco = elenco;
            foreach (var artista in Elenco)
            {
                artista.adicionarFilme(this);
            }
        }
        Titulo = titulo;
        Duracao = duracao;
    }

    public void adicionarElenco(Artista artista)
    {
        Elenco.Add(artista);
        if (!artista.filmesQueAtuou.Contains(this))
        {
            artista.adicionarFilme(this);
        };
    }

    public void listarElenco()
    {
  
        foreach (var artista in Elenco)
        {
            Console.WriteLine(artista.nome);
        }
    }
}

