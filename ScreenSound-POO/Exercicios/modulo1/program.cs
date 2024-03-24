/**using Admin.Filme;
void registerMovie()
{
    Artista tim = new("Tim Robbins", 19);
    Filme filme = new Filme("Um sonho de liberdade", 142, new List<Artista>() { tim, new("Morgan Freeman", 19) });
    Filme filme2 = new Filme("O poderoso chefão", 175, new List<Artista>() { new("Marlon Brando", 19), new("Al Pacino", 19), new("Talia Shire", 19) });
    Filme filme3 = new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista>() { new("Christian Bale", 19), new("Heath Ledger", 19), new("Maggie Gyleenhaal", 19) });
    Filme filme4 = new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista>() { new("Elijah Wood", 19), new("Ian McKellen", 19), new("Viggo Mortensen", 19) });
    Filme filme5 = new Filme("Green Book - O Guia", 130, new List<Artista>() { new("Viggo Mortensen", 19), new("Mahershala Ali", 90) });
    Filme filme6 = new Filme("Green Book - O Guia", 130, new List<Artista>() { tim, new("Mahershala Ali", 90) });
    Filme filme7 = new Filme("Green Book - O Guia", 130, new List<Artista>() { tim, new("Mahershala Ali", 90) });
    List<Filme> filmes = new List<Filme>();
    filmes.Add(filme);
    filmes.Add(filme2);
    filmes.Add(filme3);
    filmes.Add(filme4);
    filmes.Add(filme5);
    filmes.Add(filme6);
    filmes.Add(filme7);

    foreach (Filme f in filmes)
    {
        Console.WriteLine($"Filme: {f.Titulo}");
        Console.WriteLine($"Duracao: {f.Duracao}");
        f.listarElenco();
        Console.WriteLine();
    }
}

registerMovie();**/