using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string caminho = @"C:\Users\Mateus\source\repos\exercicios3\estoque.xml";


        XDocument doc = XDocument.Load(caminho);

      
        foreach (var item in doc.Root.Elements("item"))
        {
            if (item.Element("nome").Value == "Mouse")
            {
    
                item.Element("quantidade").Value = "10";
                Console.WriteLine("Mouse atualizado para quantidade 10!");
            }
        }


        doc.Save(caminho);

        Console.WriteLine(doc.ToString());
    }
}