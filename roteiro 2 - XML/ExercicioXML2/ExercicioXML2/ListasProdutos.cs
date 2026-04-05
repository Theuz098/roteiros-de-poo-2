using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Produtos")]
public class ListaProdutos
{
    [XmlElement("Produto")]
    public List<Produto> Produtos { get; set; }
}