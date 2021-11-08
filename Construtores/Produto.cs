using System;
using System.Globalization;

namespace Construtores
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //public Produto()
        //{
        //    Quantidade = 0;
        //}
        //public Produto(string nome, double preco) : this()
        //{
        //    Nome = nome;
        //    Preco = preco;
        //}
        //public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        //{
        //    Quantidade = quantidade;
        //} Referenciar outro construtor em um construtor


        public Produto()
        {
        } //contrutor padrão

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        } 
        
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0;
        } //construtor opcional
 
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
