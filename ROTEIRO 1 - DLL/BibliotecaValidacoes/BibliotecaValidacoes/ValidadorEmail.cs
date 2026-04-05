namespace BibliotecaValidacoes
{
    public class ValidadorEmail
    {
        public bool Validar(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
    }
}