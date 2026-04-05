using System;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
         XDocument doc = XDocument.Load(@"C:\Users\Mateus\source\repos\exercicio 1\alunos.xml");

        var alunos = doc.Root.Elements("aluno");

        foreach (var aluno in alunos)
        {
            string nome = aluno.Element("nome").Value;
            string curso = aluno.Element("curso").Value;

            Console.WriteLine($"Nome: {nome} | Curso: {curso}");
        }
    }
}