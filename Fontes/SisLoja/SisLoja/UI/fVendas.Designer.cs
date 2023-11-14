namespace SisLoja.UI
{
    partial class fVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorParcial = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblNumItens = new System.Windows.Forms.Label();
            this.pLista = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.dtListaProdutos = new System.Windows.Forms.DataGridView();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodVenda = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.pUltimoItem = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pInfo.SuspendLayout();
            this.pLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaProdutos)).BeginInit();
            this.pUltimoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pInfo
            // 
            this.pInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.pInfo.Controls.Add(this.lblValorTotal);
            this.pInfo.Controls.Add(this.lblValorParcial);
            this.pInfo.Controls.Add(this.lblDesc);
            this.pInfo.Controls.Add(this.lblNumItens);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pInfo.Location = new System.Drawing.Point(845, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(305, 660);
            this.pInfo.TabIndex = 6;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(113)))));
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotal.ForeColor = System.Drawing.Color.White;
            this.lblValorTotal.Location = new System.Drawing.Point(0, 0);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblValorTotal.Size = new System.Drawing.Size(305, 87);
            this.lblValorTotal.TabIndex = 0;
            this.lblValorTotal.Text = "0.00";
            this.lblValorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblValorParcial
            // 
            this.lblValorParcial.AutoSize = true;
            this.lblValorParcial.BackColor = System.Drawing.Color.Transparent;
            this.lblValorParcial.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorParcial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblValorParcial.Location = new System.Drawing.Point(13, 270);
            this.lblValorParcial.Name = "lblValorParcial";
            this.lblValorParcial.Size = new System.Drawing.Size(113, 25);
            this.lblValorParcial.TabIndex = 2;
            this.lblValorParcial.Text = "Total Parcial";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblDesc.Location = new System.Drawing.Point(13, 229);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(173, 25);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descontos:  0,00 R$";
            // 
            // lblNumItens
            // 
            this.lblNumItens.AutoSize = true;
            this.lblNumItens.BackColor = System.Drawing.Color.Transparent;
            this.lblNumItens.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblNumItens.Location = new System.Drawing.Point(13, 188);
            this.lblNumItens.Name = "lblNumItens";
            this.lblNumItens.Size = new System.Drawing.Size(152, 25);
            this.lblNumItens.TabIndex = 0;
            this.lblNumItens.Text = "Número de Itens";
            // 
            // pLista
            // 
            this.pLista.BackColor = System.Drawing.Color.White;
            this.pLista.Controls.Add(this.label2);
            this.pLista.Controls.Add(this.tbCodBar);
            this.pLista.Controls.Add(this.label1);
            this.pLista.Controls.Add(this.tbNum);
            this.pLista.Controls.Add(this.dtListaProdutos);
            this.pLista.Controls.Add(this.lblCodVenda);
            this.pLista.Controls.Add(this.lblData);
            this.pLista.Controls.Add(this.label3);
            this.pLista.Controls.Add(this.tbQtd);
            this.pLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLista.Location = new System.Drawing.Point(0, 0);
            this.pLista.Name = "pLista";
            this.pLista.Size = new System.Drawing.Size(845, 660);
            this.pLista.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(47, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código de Barras";
            // 
            // tbCodBar
            // 
            this.tbCodBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tbCodBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.tbCodBar.Location = new System.Drawing.Point(47, 422);
            this.tbCodBar.Name = "tbCodBar";
            this.tbCodBar.Size = new System.Drawing.Size(333, 29);
            this.tbCodBar.TabIndex = 40;
            this.tbCodBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodBar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(414, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tamanho";
            // 
            // tbNum
            // 
            this.tbNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tbNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.tbNum.Location = new System.Drawing.Point(414, 422);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 29);
            this.tbNum.TabIndex = 2;
            this.tbNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNum_KeyDown);
            // 
            // dtListaProdutos
            // 
            this.dtListaProdutos.AllowUserToAddRows = false;
            this.dtListaProdutos.AllowUserToDeleteRows = false;
            this.dtListaProdutos.AllowUserToResizeRows = false;
            this.dtListaProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dtListaProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtListaProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtListaProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(77)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imagem,
            this.Nome,
            this.Qtd,
            this.Valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtListaProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtListaProdutos.EnableHeadersVisualStyles = false;
            this.dtListaProdutos.Location = new System.Drawing.Point(33, 90);
            this.dtListaProdutos.MultiSelect = false;
            this.dtListaProdutos.Name = "dtListaProdutos";
            this.dtListaProdutos.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Control;
            this.dtListaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtListaProdutos.RowHeadersVisible = false;
            this.dtListaProdutos.RowTemplate.Height = 50;
            this.dtListaProdutos.RowTemplate.ReadOnly = true;
            this.dtListaProdutos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtListaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListaProdutos.Size = new System.Drawing.Size(782, 305);
            this.dtListaProdutos.StandardTab = true;
            this.dtListaProdutos.TabIndex = 30;
            // 
            // Imagem
            // 
            this.Imagem.HeaderText = "Imagem";
            this.Imagem.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imagem.Width = 75;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 500;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd.";
            this.Qtd.Name = "Qtd";
            this.Qtd.ReadOnly = true;
            this.Qtd.Width = 75;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor un.";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 150;
            // 
            // lblCodVenda
            // 
            this.lblCodVenda.AutoSize = true;
            this.lblCodVenda.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblCodVenda.Location = new System.Drawing.Point(434, 37);
            this.lblCodVenda.Name = "lblCodVenda";
            this.lblCodVenda.Size = new System.Drawing.Size(173, 32);
            this.lblCodVenda.TabIndex = 9;
            this.lblCodVenda.Text = "Operação:0001";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblData.Location = new System.Drawing.Point(33, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(183, 47);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data/Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(564, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantidade";
            // 
            // tbQtd
            // 
            this.tbQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.tbQtd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.tbQtd.Location = new System.Drawing.Point(564, 422);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(100, 29);
            this.tbQtd.TabIndex = 3;
            this.tbQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbQtd_KeyDown);
            // 
            // pUltimoItem
            // 
            this.pUltimoItem.BackColor = System.Drawing.Color.White;
            this.pUltimoItem.Controls.Add(this.lblProduto);
            this.pUltimoItem.Controls.Add(this.lblPreco);
            this.pUltimoItem.Controls.Add(this.pbImg);
            this.pUltimoItem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pUltimoItem.Location = new System.Drawing.Point(0, 469);
            this.pUltimoItem.Name = "pUltimoItem";
            this.pUltimoItem.Size = new System.Drawing.Size(845, 191);
            this.pUltimoItem.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblProduto.Location = new System.Drawing.Point(208, 43);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(96, 40);
            this.lblProduto.TabIndex = 40;
            this.lblProduto.Text = "Nome";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(77)))));
            this.lblPreco.Location = new System.Drawing.Point(208, 100);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(88, 40);
            this.lblPreco.TabIndex = 39;
            this.lblPreco.Text = "Preço";
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(3, 3);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(184, 184);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 38;
            this.pbImg.TabStop = false;
            // 
            // fVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.pUltimoItem);
            this.Controls.Add(this.pLista);
            this.Controls.Add(this.pInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fVendas";
            this.Text = "BKP";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCodBar_KeyDown);
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.pLista.ResumeLayout(false);
            this.pLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtListaProdutos)).EndInit();
            this.pUltimoItem.ResumeLayout(false);
            this.pUltimoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pInfo;
        private Label lblValorTotal;
        private Label lblValorParcial;
        private Label lblDesc;
        private Label lblNumItens;
        private Panel pLista;
        private Label label1;
        private TextBox tbNum;
        public DataGridView dtListaProdutos;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Valor;
        private Label lblCodVenda;
        private Label lblData;
        private Label label3;
        private TextBox tbQtd;
        private Label label2;
        public TextBox tbCodBar;
        private Panel pUltimoItem;
        private Label lblProduto;
        private Label lblPreco;
        private PictureBox pbImg;
    }
}