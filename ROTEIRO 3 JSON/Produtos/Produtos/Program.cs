using Newtonsoft.Json;

class Produto
{
    [JsonProperty(Order = 1)]
    public int Id { get; set; }

    [JsonProperty("product_name", Order = 2)]
    [JsonRequired]
    public string Nome { get; set; }

    [JsonProperty("product_price", Order = 3)]
    [JsonRequired]
    public double Preco { get; set; }

    [JsonProperty(Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(Order = 5)]
    public string Fornecedor { get; set; }

    [JsonIgnore]
    public string CodigoInterno { get; set; }
}

class Program
{
    static void Main()
    {
   
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Notebook", Preco = 3500, Estoque = 10, Fornecedor = "Dell", CodigoInterno = "NB-001" },
            new Produto { Id = 2, Nome = "Mouse", Preco = 80, Estoque = 50, Fornecedor = "Logitech", CodigoInterno = "MS-002" },
            new Produto { Id = 3, Nome = "Teclado", Preco = 150, Estoque = 30, Fornecedor = null, CodigoInterno = "TC-003" }
        };


        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore
        };

        string json = JsonConvert.SerializeObject(produtos, settings);
        File.WriteAllText("produtos.json", json);
        Console.WriteLine("Arquivo produtos.json gravado!\n");
        Console.WriteLine(json);


        Console.WriteLine("\n--- Lendo o arquivo ---\n");
        string jsonLido = File.ReadAllText("produtos.json");
        List<Produto> produtosLidos = JsonConvert.DeserializeObject<List<Produto>>(jsonLido);

        foreach (Produto p in produtosLidos)
        {
            Console.WriteLine($"Id: {p.Id}");
            Console.WriteLine($"Nome: {p.Nome}");
            Console.WriteLine($"Preço: {p.Preco}");
            Console.WriteLine($"Estoque: {p.Estoque}");
            Console.WriteLine($"Fornecedor: {p.Fornecedor}");
            Console.WriteLine("---");
        }

      
        Console.WriteLine("\n--- Testando validação ---");
        try
        {
            JsonSerializerSettings settingsValidacao = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error
            };

            string jsonInvalido = @"[{ 'Id': 4, 'Estoque': 5 }]";
            List<Produto> invalido = JsonConvert.DeserializeObject<List<Produto>>(jsonInvalido, settingsValidacao);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro capturado: {ex.Message}");
        }
    }
}