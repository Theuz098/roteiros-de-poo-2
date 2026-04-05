using System;
using Xunit;
using System;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class CalculadoraIMCTests
    {
        [Fact]
        public void Calcular_DeveRetornarIMCCorreto_QuandoPesoE70AlturaE175()
        {
            var calc = new CalculadoraIMC();
            var resultado = calc.Calcular(70, 1.75);
            Assert.Equal(22.86, resultado, 2);
        }

        [Fact]
        public void Classificar_DeveRetornarAbaixoDoPeso_QuandoIMCFor17()
        {
            var calc = new CalculadoraIMC();
            Assert.Equal("Abaixo do peso", calc.Classificar(17));
        }

        [Fact]
        public void Classificar_DeveRetornarSobrepeso_QuandoIMCFor26()
        {
            var calc = new CalculadoraIMC();
            Assert.Equal("Sobrepeso", calc.Classificar(26));
        }

        [Fact]
        public void Calcular_DeveLancarExcecao_QuandoAlturaForZeroOuNegativa()
        {
            var calc = new CalculadoraIMC();
            Assert.Throws<ArgumentException>(() => calc.Calcular(70, 0));
        }
    }
}