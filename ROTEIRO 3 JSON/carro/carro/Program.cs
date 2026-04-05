using Newtonsoft.Json;

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

class Program
{
    static void Main()
    {
     
        List<Carro> carros = new List<Carro>
        {
            new Carro { Marca = "Toyota", Modelo = "Corolla", Ano = 2020 },
            new Carro { Marca = "Honda", Modelo = "Civic", Ano = 2021 },
            new Carro { Marca = "Ford", Modelo = "Ka", Ano = 2019 }
        };

       
        string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
        File.WriteAllText("carros.json", json);
        Console.WriteLine("Arquivo gravado com sucesso!\n");

      
        string jsonLido = File.ReadAllText("carros.json");
        List<Carro> carrosLidos = JsonConvert.DeserializeObject<List<Carro>>(jsonLido);

        foreach (Carro c in carrosLidos)
        {
            Console.WriteLine($"Marca: {c.Marca} | Modelo: {c.Modelo} | Ano: {c.Ano}");
        }
    }
}