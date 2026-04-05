using Xunit;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class ConversorTemperaturaTests
    {
        [Theory]
        [InlineData(0, 32)]
        [InlineData(100, 212)]
        public void CelsiusParaFahrenheit_DeveRetornarValorCorreto(double celsius, double esperado)
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.CelsiusParaFahrenheit(celsius);
            Assert.Equal(esperado, resultado, 2);
        }

        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void FahrenheitParaCelsius_DeveRetornarValorCorreto(double fahrenheit, double esperado)
        {
            var conversor = new ConversorTemperatura();
            var resultado = conversor.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(esperado, resultado, 2);
        }
    }
}