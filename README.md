
BibliotecaGeometria - Documentação
O que é?

DLL que realiza cálculos geométricos de área e perímetro.
Como usar?
1. Adicionar referência

    Clique com botão direito em Dependências
    Adicionar Referência → Procurar
    Selecione o arquivo BibliotecaGeometria.dll

2. Importar no código
csharp

using BibliotecaGeometria;

3. Métodos disponíveis
Método	Parâmetros	Retorno
AreaRetangulo	largura, altura	Área do retângulo
AreaCirculo	raio	Área do círculo
PerimetroRetangulo	largura, altura	Perímetro do retângulo
4. Exemplo de uso
csharp

Geometria geo = new Geometria();

double area = geo.AreaRetangulo(5, 3);        // retorna 15
double perimetro = geo.PerimetroRetangulo(5, 3); // retorna 16
double circulo = geo.AreaCirculo(4);           // retorna 50.26
