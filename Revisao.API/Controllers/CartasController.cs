using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartasController : ControllerBase
    {
        private readonly ICartaService _cartaService;

        public CartasController(ICartaService cartaService)
        {
            _cartaService = cartaService;
        }

        [HttpPost(Name = "AdicionarCartas")]
        public IActionResult Post(NovaCartaViewModel novaCartaViewModel)
        {
            _cartaService.AdicionarCartas(novaCartaViewModel);

            return Ok();
        }


        [HttpGet(Name = "ObterTodosAsCartas")]
        public IActionResult Get()
        {
            return Ok(_cartaService.ObterTodos());
        }
    }
}
