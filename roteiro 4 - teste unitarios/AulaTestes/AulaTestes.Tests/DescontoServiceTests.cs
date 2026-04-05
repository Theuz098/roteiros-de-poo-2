using Xunit;
using System;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class DescontoServiceTests
    {
        // Parte A — testes individuais com [Fact]

        [Fact]
        public void AplicarDesconto_DeveRetornar90_QuandoValor100Percentual10()
        {
            var service = new DescontoService();
            Assert.Equal(90, service.AplicarDesconto(100, 10));
        }

        [Fact]
        public void AplicarDesconto_DeveRetornar100_QuandoValor200Percentual50()
        {
            var service = new DescontoService();
            Assert.Equal(100, service.AplicarDesconto(200, 50));
        }

        [Fact]
        public void AplicarDesconto_DeveRetornar80_QuandoPercentualForZero()
        {
            var service = new DescontoService();
            Assert.Equal(80, service.AplicarDesconto(80, 0));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoValorForNegativo()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(-10, 10));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoPercentualForMenorQueZero()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, -5));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoPercentualForMaiorQue100()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, 150));
        }

        // Parte B — reescrita com [Theory] e [InlineData]

        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 50, 100)]
        [InlineData(80, 0, 80)]
        public void AplicarDesconto_DeveRetornarValorCorreto(double valor, double percentual, double esperado)
        {
            var service = new DescontoService();
            var resultado = service.AplicarDesconto(valor, percentual);
            Assert.Equal(esperado, resultado);
        }
    }
}