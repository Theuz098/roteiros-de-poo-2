using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

class Program
{
    static async Task Main()
    {
        string url = "https://www.w3schools.com/xml/simple.xml";

        
        using (HttpClient client = new HttpClient())
        {
            
            string response = await client.GetStringAsync(url);

        
            XDocument doc = XDocument.Parse(response);

            Console.WriteLine("=== Cardápio ===\n");

          
            foreach (var food in doc.Root.Elements("food"))
            {
                string nome = food.Element("name").Value;
                string preco = food.Element("price").Value;

                Console.WriteLine($"Nome: {nome} | Preço: {preco}");
            }
        }
    }
}