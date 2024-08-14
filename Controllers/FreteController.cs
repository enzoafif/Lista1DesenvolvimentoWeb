using Lista1DesenvolvimentoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lista1DesenvolvimentoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FreteController : ControllerBase
    {
        [HttpPost]
        public IActionResult CalcularFrete(Frete frete)
        {
            const double TAXACM3 = 0.01;

            var volume = frete.Altura * frete.Largura * frete.Comprimento;

            int tarifaEstado;

            if(frete.UF == "SP")
            {
                tarifaEstado = 50;
            }else if(frete.UF == "RJ")
            {
                tarifaEstado = 60;
            }else if(frete.UF == "MG")
            {
                tarifaEstado = 55;
            }else
            {
                tarifaEstado = 70;
            }

            double total = volume * TAXACM3 + tarifaEstado;

            return Ok($"O valor do frete é {total}");
        }
    }
}
