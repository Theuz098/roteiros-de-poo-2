using BibliotecaGeometria;

Geometria geo = new Geometria();

Console.WriteLine(" Calculadora de Geometria ");

Console.Write("Digite a largura do retangulo: ");
double largura = double.Parse(Console.ReadLine());
Console.Write("Digite a altura do retangulo: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine("Area do Retangulo: " + geo.AreaRetangulo(largura, altura));
Console.WriteLine("Perimetro do Retangulo: " + geo.PerimetroRetangulo(largura, altura));

Console.WriteLine("");
Console.Write("Digite o raio do circulo: ");
double raio = double.Parse(Console.ReadLine());
Console.WriteLine("Area do Circulo: " + geo.AreaCirculo(raio));