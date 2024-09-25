using Microsoft.AspNetCore.Mvc;
using ProvaH125.Models;
using ProvaH125.Services;

namespace ProvaH125.Controller
{
    [ApiController]
    [Route("api/carta")]
    public class CartaController : ControllerBase
    {
        private readonly ICartaRepository _cartaRepository;

        public CartaController(ICartaRepository cartaRepository)
        {
            _cartaRepository = cartaRepository;
        }

        [HttpPost]
        [Route("Inserir")]
        public IActionResult Inserir([FromBody] Carta carta)
        {
            if (carta == null)
            {
                return BadRequest("Carta não pode ser nula.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           var result = _cartaRepository.Inserir(carta);
            if (result == null)             {
                return StatusCode(500, "Erro ao inserir a carta. Tente novamente.");
            }

            return CreatedAtAction(nameof(ObterPorCrianca), new { crianca = carta.NomeCrianca }, carta);
        }

        [HttpGet]
        [Route("ObterPorCrianca/{crianca}")]
        public IActionResult ObterPorCrianca(string crianca)
        {
            var cartaPesquisada = _cartaRepository.ObterCartaPorCrianca(crianca);

            if (cartaPesquisada is null)
            {
                return NotFound($"Criança com carta {crianca} não encontrada.");
            }

            return Ok(cartaPesquisada);
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            var cartas = _cartaRepository.ObterTodasCartas();
            return Ok(cartas);
        }
    }
}
