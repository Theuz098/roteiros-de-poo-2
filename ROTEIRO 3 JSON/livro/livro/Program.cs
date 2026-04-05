using Newtonsoft.Json;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main()
    {
        Livro livro = new Livro
        {
            Titulo = "Dois Mundos, Um Herói",
            Autor = "RezendeEvil",
            Ano = 2015
        };

        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);
    }
}