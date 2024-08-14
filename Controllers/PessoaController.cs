using Lista1DesenvolvimentoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lista1DesenvolvimentoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        [Route("calcularImc")]
        public IActionResult CalcularImc(Pessoa pessoa)
        {
            //var pesoCorrigido = Convert.ToDouble(pessoa.Peso.ToString().Replace(',', '.'));
            //var alturaCorrigida = Convert.ToDouble(pessoa.Altura.ToString().Replace(',', '.'));

            var imc = CalcularImc(pessoa.Peso, pessoa.Altura);

            return Ok($"Seu IMC é {imc}");
        }

        [HttpPost]
        [Route("consultaTabelaImc")]
        public IActionResult ConsultaTabelaImc(double imc)
        {
            string resultado = imc switch
            {
                < 16.9 => "Muito abaixo do peso",
                >= 17 and <= 18.4 => "Abaixo do peso",
                >= 18.5 and <= 24.9 => "Peso normal",
                >= 25 and <= 29.9 => "Acima do peso",
                >= 30 and <= 34.9 => "Obesidade grau I",
                >= 35 and <= 40 => "Obesidade grau II",
                > 40 => "Obesidade grau III",
                _ => "Não foi possível identificar o IMC"
            };

            return Ok(resultado);
        }

        private double CalcularImc(double peso, double altura)
        {
            return peso / (altura * altura);
        }
    }
}
