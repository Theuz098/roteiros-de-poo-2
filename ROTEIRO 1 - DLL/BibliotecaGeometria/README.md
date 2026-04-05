BibliotecaGeometria

DLL que realiza calculos geometricos de area e perimetro.

Como usar

1. Adicionar referencia
- Clique com botao direito em Dependencias
- Adicionar Referencia -> Procurar
- Selecione o arquivo BibliotecaGeometria.dll

2. Importar no codigo
using BibliotecaGeometria;

3. Metodos disponiveis

AreaRetangulo(largura, altura) - Calcula a area do retangulo
AreaCirculo(raio) - Calcula a area do circulo
PerimetroRetangulo(largura, altura) - Calcula o perimetro do retangulo

4. Exemplo de uso

Geometria geo = new Geometria();

double area = geo.AreaRetangulo(5, 3);           // retorna 15
double perimetro = geo.PerimetroRetangulo(5, 3); // retorna 16
double circulo = geo.AreaCirculo(4);             // retorna 50.26

