using ProvaH125.Models;

namespace ProvaH125.Services
{
    public class CartaRepository
    {
        public interface ICartaRepository
        {
            void AdicionarCarta(Carta carta);
            List<Carta> ListarCartas();
        }

    }
}
