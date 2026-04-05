using BibliotecaConversao;

Conversao conv = new Conversao();

Console.WriteLine("Conversão de Temperatura ");
Console.Write("Digite a temp em Celsius: ");
double celsius = double.Parse(Console.ReadLine());
Console.WriteLine("Resultado: " + conv.CelsiusParaFahrenheit(celsius) + "°F");

Console.WriteLine("");
Console.WriteLine("Conversão de Distância");
Console.Write("Digite os metros: ");
double metros = double.Parse(Console.ReadLine());
Console.WriteLine("Resultado: " + conv.MetrosParaQuilometros(metros) + "km");

Console.WriteLine("");
Console.WriteLine("Conversão de Moeda");
Console.Write("Digite o valor: ");
double valor = double.Parse(Console.ReadLine());
Console.Write("Digite a taxa de cambio: ");
double taxa = double.Parse(Console.ReadLine());
Console.WriteLine("Resultado: " + conv.ConverterMoeda(valor, taxa));