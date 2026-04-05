Exercício 0 – Identificar e corrigir erros

Questão A

O erro está no valor esperado do Assert.Equal. O método Somar(2, 3) retorna 5, mas o teste esperava 4.

Errado
Assert.Equal(4, resultado);

Corrigido
[Fact]
public void Somar_DeveRetornar5()
{
    var calc = new Calculadora();
    var resultado = calc.Somar(2, 3);
    Assert.Equal(5, resultado);
}

Questão B
O erro está na chamada Dividir(10, 2), que é uma divisão válida e não lança exceção. A exceção DivideByZeroException só ocorre quando o divisor é zero.

Errado
Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 2));

 Corrigido
[Fact]
public void Dividir_DeveLancarExcecao()
{
    var calc = new Calculadora();
    Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
}

Questão C
O erro está no Assert.Empty, que verifica uma lista nova criada na hora e não o carrinho real. O teste nunca verifica o carrinho de verdade.

 Errado
Assert.Empty(new List<Item> { new Item() });

Corrigido
[Fact]
public void Carrinho_DeveEstarVazioAposLimpar()
{
    var carrinho = new Carrinho();
    carrinho.Adicionar(new Item { Nome = "Produto", Preco = 15 });
    carrinho.Limpar();
    Assert.Equal(0, carrinho.Quantidade());
}

Questão D
O erro está no valor esperado. O IMC 31 se enquadra como "Obesidade" (maior ou igual a 30), não como "Peso normal".

Errado
Assert.Equal("Peso normal", resultado);

Corrigido
[Fact]
public void Classificar_DeveRetornarObesidade_QuandoIMCFor31()
{
    var calc = new CalculadoraIMC();
    var resultado = calc.Classificar(31);
    Assert.Equal("Obesidade", resultado);
