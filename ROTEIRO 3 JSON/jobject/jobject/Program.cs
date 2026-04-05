
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
    
        string jsonConfig = @"{
            'Servidor': 'localhost',
            'Porta': 3306,
            'Usuario': 'admin'
        }";

        JObject config = JObject.Parse(jsonConfig);

        Console.WriteLine("Antes da alteração:");
        Console.WriteLine($"Servidor: {config["Servidor"]}");
        Console.WriteLine($"Porta: {config["Porta"]}");
        Console.WriteLine($"Usuario: {config["Usuario"]}");

    
        config["Porta"] = 5432;

        Console.WriteLine("\nDepois da alteração:");
        Console.WriteLine($"Servidor: {config["Servidor"]}");
        Console.WriteLine($"Porta: {config["Porta"]}");
        Console.WriteLine($"Usuario: {config["Usuario"]}");
    }
}