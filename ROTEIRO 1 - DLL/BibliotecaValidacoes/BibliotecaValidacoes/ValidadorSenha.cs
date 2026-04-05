namespace BibliotecaValidacoes
{
    public class ValidadorSenha
    {
        public bool Validar(string senha, int tamanhoMinimo = 8)
        {
            return senha.Length >= tamanhoMinimo;
        }
    }
}
