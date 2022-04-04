using Calculadora.Controllers;
using Xunit;

namespace Calculadora.Test
{
    public class CalculadoraTest
    {
        private readonly CalculadoraController calculadoraController;
        public CalculadoraTest()
        {
            calculadoraController = new CalculadoraController();
        }

        [Fact]
        public void Somar()
        {
            var valorA = 10;
            var valorB = 20;
            var calculadora = new Model.Calculadora(valorA, valorB);

            var soma = calculadoraController.Somar(calculadora);
            var resultadoEsperado = 30;

            Assert.Equal(resultadoEsperado, soma);
        }
    }
}
