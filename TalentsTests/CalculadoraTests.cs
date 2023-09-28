using System;
using Talents;
using Xunit;

namespace TalentsTests
{
    public class CalculadoraTests
    {
        public Calculadora construirClasse()
        {
            string data = DateTime.UtcNow.ToString();
            Calculadora calc = new Calculadora(data);
            return calc;


        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int value1, int value2, int resultadoExp)
        {
            var calc = construirClasse();

            int resultadoResp = calc.Somar(value1, value2);

            Assert.Equal(resultadoExp, resultadoResp);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 4, 6)]
        public void TesteSubtrair(int value1, int value2, int resultadoExp)
        {
            var calc = construirClasse();

            int resultadoResp = calc.Subtrair(value1, value2);

            Assert.Equal(resultadoExp, resultadoResp);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int value1, int value2, int resultadoExp)
        {
            var calc = construirClasse();

            int resultadoResp = calc.Multiplicar(value1, value2);

            Assert.Equal(resultadoExp, resultadoResp);
        }

        [Theory]
        [InlineData(18, 2, 9)]
        [InlineData(25, 5, 5)]
        public void TesteDividir(int value1, int value2, int resultadoExp)
        {
            var calc = construirClasse();

            int resultadoResp = calc.Dividir(value1, value2);

            Assert.Equal(resultadoExp, resultadoResp);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            var calc = construirClasse();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(10, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            var calc = construirClasse();

            calc.Somar(1, 2);
            calc.Somar(4, 2);
            calc.Somar(9, 5);
            calc.Somar(8, 6);
            calc.Somar(10, 7);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
