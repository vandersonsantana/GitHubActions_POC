using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        [HttpPost]
        public decimal Somar(Model.Calculadora calculadora)
        {
            return calculadora.ValorA - calculadora.ValorB;
        }
    }
}
