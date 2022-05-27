public class AnimeRepositorio : IRepositorio<Animes>
{
    private List<Animes> listaAnimes = new List<Animes>();
    public void Atualiza(int id, Animes entidade)
    {
        listaAnimes[id] = entidade;
    }

    public void Exclui(int id)
    {
        listaAnimes[id].Excluir();
    }

    public void Insere(Animes entidade)
    {
        listaAnimes.Add(entidade);
    }

    public List<Animes> Lista()
    {
        return listaAnimes;
    }

    public int ProximoId()
    {
        return listaAnimes.Count;
    }

    public Animes RetornaPorId(int id)
    {
        return listaAnimes[id];
    }
}
