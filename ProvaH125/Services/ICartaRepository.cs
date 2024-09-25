namespace ProvaH125.Models
{
    public class ICartaRepository
    {
	public interface IAlunoRepository
        {
            public List<Carta> ObterTodasCartas();
            public Carta CartasPorNome(string nome);

            public void Inserir(Carta carta);
        }
    }
}
