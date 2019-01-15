namespace Sistema_Cantina
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoDoProduto = new System.Windows.Forms.TextBox();
            this.listProdutos = new System.Windows.Forms.ListBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.picBoxProduto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciador de Cantina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CÓDIGO DO PRODUTO:";
            // 
            // txtCodigoDoProduto
            // 
            this.txtCodigoDoProduto.Location = new System.Drawing.Point(15, 130);
            this.txtCodigoDoProduto.Name = "txtCodigoDoProduto";
            this.txtCodigoDoProduto.Size = new System.Drawing.Size(125, 20);
            this.txtCodigoDoProduto.TabIndex = 4;
            this.txtCodigoDoProduto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtCodigoDoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoDoProduto_KeyDown_1);
            // 
            // listProdutos
            // 
            this.listProdutos.FormattingEnabled = true;
            this.listProdutos.Location = new System.Drawing.Point(172, 102);
            this.listProdutos.Name = "listProdutos";
            this.listProdutos.Size = new System.Drawing.Size(210, 186);
            this.listProdutos.TabIndex = 5;
            this.listProdutos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(12, 338);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(332, 39);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total R$ 0,00";
            // 
            // picBoxProduto
            // 
            this.picBoxProduto.Location = new System.Drawing.Point(12, 156);
            this.picBoxProduto.Name = "picBoxProduto";
            this.picBoxProduto.Size = new System.Drawing.Size(141, 144);
            this.picBoxProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProduto.TabIndex = 7;
            this.picBoxProduto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 386);
            this.Controls.Add(this.picBoxProduto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.listProdutos);
            this.Controls.Add(this.txtCodigoDoProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sistema de Cantina";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoDoProduto;
        private System.Windows.Forms.ListBox listProdutos;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.PictureBox picBoxProduto;
    }
}

