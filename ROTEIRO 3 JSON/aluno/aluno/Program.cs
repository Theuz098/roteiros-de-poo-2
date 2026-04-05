using Newtonsoft.Json;
using Newtonsoft.Json;

class Aluno
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Curso { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("aluno.json");
        Aluno aluno = JsonConvert.DeserializeObject<Aluno>(json);

        Console.WriteLine($"Nome: {aluno.Nome}");
        Console.WriteLine($"Idade: {aluno.Idade}");
        Console.WriteLine($"Curso: {aluno.Curso}");
    }
}