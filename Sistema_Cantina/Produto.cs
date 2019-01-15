namespace Sistema_Cantina
{
    public class Produto
    {

        public float ObterPreco()
        {
            return this.Preco;
        }

        public int ObterCodigo()
        {
            return this.Codigo;
        }

        public string Imprimir()
        {
            return this.Codigo + " -- " + this.Nome + " -- R$ " + this.Preco; 
        }

        public Produto(int codigo, string nome, float preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        private int Codigo { get; set; }
        private string Nome { get; set; }
        private float Preco { get; set; }

    }
}
