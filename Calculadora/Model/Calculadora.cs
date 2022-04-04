namespace Calculadora.Model
{
    public class Calculadora
    {
        public Calculadora(int valorA, int valorB) => (ValorA, ValorB) = (valorA, valorB);

        public int ValorA { get; set; }
        public int ValorB { get; set; }
    }
}
