using Xunit;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class CarrinhoTests
    {
        [Fact]
        public void Total_DeveRetornarSomaCorreta_QuandoItensForemAdicionados()
        {
       
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Arroz", Preco = 10.0 });
            carrinho.Adicionar(new Item { Nome = "Feijão", Preco = 8.5 });

         
            var total = carrinho.Total();

         
            Assert.Equal(18.5, total);
        }

        [Fact]
        public void Limpar_DeveZerarCarrinho_QuandoChamado()
        {
       
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto", Preco = 50.0 });

         
            carrinho.Limpar();

      
            Assert.Equal(0, carrinho.Quantidade());
        }

        [Fact]
        public void Quantidade_DeveRetornarNumeroCorreto_QuandoItensForemAdicionados()
        {
            
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "A", Preco = 5.0 });
            carrinho.Adicionar(new Item { Nome = "B", Preco = 10.0 });
            carrinho.Adicionar(new Item { Nome = "C", Preco = 15.0 });

            
            var quantidade = carrinho.Quantidade();

            
            Assert.Equal(3, quantidade);
        }
    }
}