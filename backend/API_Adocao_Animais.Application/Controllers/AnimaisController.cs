using API_Adocao_Animais.Application.DTOs;
using API_Adocao_Animais.Domain.Entities;
using API_Adocao_Animais.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API_Adocao_Animais.Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimaisController : ControllerBase
    {
        private readonly IAdocaoService _adocaoService;

        public AnimaisController(IAdocaoService adocaoService)
        {
            _adocaoService = adocaoService;
        }

        [HttpGet]
        public IActionResult GetAnimais()
        {
            var animais = _adocaoService.GetTodosAnimais();
            return Ok(animais);
        }

        [HttpPost("AdicionarAnimal")]
        public IActionResult AdicionarAnimal([FromBody] AnimalDTO animal)
        {
            Animal ani;

            if (animal.Especie == "Cachorro")
            {
                ani = new Cachorro
                {
                    Nome = animal.Nome,
                    Idade = animal.Idade
                };
            }
            else if (animal.Especie == "Gato")
            {
                ani = new Gato
                {
                    Nome = animal.Nome,
                    Idade = animal.Idade
                };
            }
            else
            {
                return BadRequest("Espécie de animal desconhecida.");
            }

            _adocaoService.AdicionarAnimal(ani);
            return Ok();
        }

        [HttpPost("AdotarAnimal")]
        public IActionResult AdotarAnimal([FromBody] AdotanteAdocaoRequest request)
        {
            _adocaoService.AdotarAnimal(request.Adotante, request.Animal);
            return Ok();
        }
    }
}
