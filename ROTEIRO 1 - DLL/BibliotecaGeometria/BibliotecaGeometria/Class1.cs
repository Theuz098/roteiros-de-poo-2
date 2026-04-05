namespace BibliotecaGeometria
{
    public class Geometria
    {
        public double AreaRetangulo(double largura, double altura)
        {
            return largura * altura;
        }

        public double AreaCirculo(double raio)
        {
            return Math.PI * raio * raio;
        }

        public double PerimetroRetangulo(double largura, double altura)
        {
            return 2 * (largura + altura);
        }
    }
}