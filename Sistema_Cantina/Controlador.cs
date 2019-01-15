using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema_Cantina
{
    public class Controlador
    {

        public static void AdicionarProduto(Produto produto, List<Produto> produtos)
        {
            produtos.Add(produto);
        }

        public static string ListarProdutos(List<Produto> produtos)
        {
            string retorno = "";

            foreach (Produto produto in produtos)
            {
                retorno += produto.Imprimir() + Environment.NewLine;
            }

            return retorno;

        }

        public static void AdicionarProdutos(ListBox listBox, List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                listBox.Items.Add(produto.Imprimir());
            }
        }

        public static float SomaDosProdutos(List<Produto> produtos)
        {
            float retorno = 0;

            foreach (Produto produto in produtos)
            {
                retorno += produto.ObterPreco();
            }

            return retorno;

        }

        public static Produto ObterProduto(int codigo, List<Produto> produtos)
        {
            return produtos.Find(f => f.ObterCodigo() == codigo);
        }

    }
}
