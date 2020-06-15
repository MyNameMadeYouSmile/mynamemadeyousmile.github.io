namespace TP6ProjetoDeBloco
{
    class Item
    {
        public int Codigo;
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Item(string Nome, int Codigo, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Codigo = Codigo;
            this.Quantidade = 0;
        }

        public AumentarQuantidade()
        {
            this.Quantidade++;
        }

        public ReduzirQuantidade()
        {
            this.Quantidade--;
        }
    }
}