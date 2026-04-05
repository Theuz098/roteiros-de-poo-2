using BibliotecaValidacoes;

ValidadorCPF cpf = new ValidadorCPF();
ValidadorEmail email = new ValidadorEmail();
ValidadorSenha senha = new ValidadorSenha();

Console.Write("Digite o CPF (so numeros): ");
string cpfDigitado = Console.ReadLine();
Console.WriteLine("CPF valido: " + cpf.Validar(cpfDigitado));

Console.Write("Digite o Email: ");
string emailDigitado = Console.ReadLine();
Console.WriteLine("Email valido: " + email.Validar(emailDigitado));

Console.Write("Digite a Senha: ");
string senhaDigitada = Console.ReadLine();
Console.WriteLine("Senha valida: " + senha.Validar(senhaDigitada));