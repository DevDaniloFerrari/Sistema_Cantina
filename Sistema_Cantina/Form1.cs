using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public partial class Form1 : Form
    {

        static private List<Produto> produtosPrateleira = new List<Produto>();
        static private List<Produto> produtosComprados = new List<Produto>();

        public Form1()
        {

            produtosPrateleira.Add(new Produto(001, "Pastel", 6f));
            produtosPrateleira.Add(new Produto(002, "Coxinha", 5f));
            produtosPrateleira.Add(new Produto(003, "Hot Dog", 12f));
            produtosPrateleira.Add(new Produto(004, "Chocolate", 3.5f));
            produtosPrateleira.Add(new Produto(005, "Suco", 8f));
            produtosPrateleira.Add(new Produto(006, "Refrigerante", 7.5f));

            InitializeComponent();
            Controlador.AdicionarProdutos(listProdutos, produtosPrateleira);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt16(txtCodigoDoProduto.Text);

                switch (codigo)
                {

                    case 1: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "pastel.jpg"; break;
                    case 2: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "coxinha.png"; break;
                    case 3: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "hotdog.jpg"; break;
                    case 4: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "chocolate.jpg"; break;
                    case 5: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "suco.png"; break;
                    case 6: picBoxProduto.ImageLocation = ConfigurationManager.AppSettings["CAMINHO_DAS_IMAGENS"] + "refrigerante.jpg"; break;
                    
                }
            }
            catch (Exception)
            {
                txtCodigoDoProduto.Clear();
            }

        }

        private void txtCodigoDoProduto_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    var codigo = Convert.ToInt16(txtCodigoDoProduto.Text);

                    if (Controlador.ObterProduto(codigo, produtosPrateleira) != null)
                    {

                        Controlador.AdicionarProduto(Controlador.ObterProduto(codigo, produtosPrateleira), produtosComprados);

                        lblValorTotal.Text = "Valor Total R$ " + Controlador.SomaDosProdutos(produtosComprados).ToString();

                        txtCodigoDoProduto.Clear();

                    }
                }
                catch (FormatException)
                {
                    txtCodigoDoProduto.Clear();
                }


            }
        }
    }
}
