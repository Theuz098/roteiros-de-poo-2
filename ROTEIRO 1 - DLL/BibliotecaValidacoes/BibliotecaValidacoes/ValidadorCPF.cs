namespace BibliotecaValidacoes
{
    public class ValidadorCPF
    {
        public bool Validar(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}