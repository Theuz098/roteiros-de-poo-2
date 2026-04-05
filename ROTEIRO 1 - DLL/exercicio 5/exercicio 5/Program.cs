using BibliotecaDeDesconto;


CalculadoraDesconto calc = new CalculadoraDesconto();


Console.WriteLine("\nCalculadora de Desconto ");
Console.Write("Digite o valor do produto: ");
double valor = double.Parse(Console.ReadLine());
Console.Write("Digite o percentual de desconto: ");
double percentual = double.Parse(Console.ReadLine());
Console.WriteLine("Valor com desconto: R$" + calc.AplicarDesconto(valor, percentual));

Console.WriteLine("\n Calculadora de Frete ");
Console.Write("Digite o peso do produto (kg): ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Digite a distancia em km: ");
double distancia = double.Parse(Console.ReadLine());
Console.WriteLine("Valor do frete: R$" + calc.CalcularFrete(peso, distancia));