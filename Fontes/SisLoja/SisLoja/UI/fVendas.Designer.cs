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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVendas));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pInfo = new Panel();
            lblValorTotal = new Label();
            lblValorParcial = new Label();
            lblDesc = new Label();
            lblNumItens = new Label();
            pLista = new Panel();
            dtListaProdutos = new DataGridView();
            lblCodVenda = new Label();
            lblData = new Label();
            pUltimoItem = new Panel();
            pBottom = new Panel();
            tbCodBar = new TextBox();
            tbNum = new TextBox();
            tbQtd = new TextBox();
            lblProduto = new Label();
            lblPreco = new Label();
            pbImg = new PictureBox();
            Imagem = new DataGridViewImageColumn();
            Nome = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            pInfo.SuspendLayout();
            pLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtListaProdutos).BeginInit();
            pUltimoItem.SuspendLayout();
            pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            SuspendLayout();
            // 
            // pInfo
            // 
            pInfo.BackColor = Color.FromArgb(246, 247, 251);
            pInfo.Controls.Add(lblValorTotal);
            pInfo.Controls.Add(lblValorParcial);
            pInfo.Controls.Add(lblDesc);
            pInfo.Controls.Add(lblNumItens);
            pInfo.Dock = DockStyle.Right;
            pInfo.Location = new Point(945, 0);
            pInfo.Name = "pInfo";
            pInfo.Size = new Size(305, 680);
            pInfo.TabIndex = 6;
            // 
            // lblValorTotal
            // 
            lblValorTotal.BackColor = Color.FromArgb(37, 77, 113);
            lblValorTotal.Font = new Font("Segoe UI", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTotal.ForeColor = Color.White;
            lblValorTotal.Location = new Point(0, 0);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.RightToLeft = RightToLeft.Yes;
            lblValorTotal.Size = new Size(305, 87);
            lblValorTotal.TabIndex = 0;
            lblValorTotal.Text = "0.00";
            lblValorTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblValorParcial
            // 
            lblValorParcial.AutoSize = true;
            lblValorParcial.BackColor = Color.Transparent;
            lblValorParcial.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorParcial.ForeColor = Color.FromArgb(64, 70, 77);
            lblValorParcial.Location = new Point(13, 270);
            lblValorParcial.Name = "lblValorParcial";
            lblValorParcial.Size = new Size(182, 25);
            lblValorParcial.TabIndex = 2;
            lblValorParcial.Text = "Total Parcial: 0,00 R$";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDesc.ForeColor = Color.FromArgb(64, 70, 77);
            lblDesc.Location = new Point(13, 229);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(173, 25);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Descontos:  0,00 R$";
            // 
            // lblNumItens
            // 
            lblNumItens.AutoSize = true;
            lblNumItens.BackColor = Color.Transparent;
            lblNumItens.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNumItens.ForeColor = Color.FromArgb(64, 70, 77);
            lblNumItens.Location = new Point(13, 188);
            lblNumItens.Name = "lblNumItens";
            lblNumItens.Size = new Size(152, 25);
            lblNumItens.TabIndex = 0;
            lblNumItens.Text = "Número de Itens";
            // 
            // pLista
            // 
            pLista.BackColor = Color.White;
            pLista.Controls.Add(dtListaProdutos);
            pLista.Controls.Add(lblCodVenda);
            pLista.Controls.Add(lblData);
            pLista.Dock = DockStyle.Fill;
            pLista.Location = new Point(0, 0);
            pLista.Name = "pLista";
            pLista.Size = new Size(945, 680);
            pLista.TabIndex = 7;
            // 
            // dtListaProdutos
            // 
            dtListaProdutos.AllowUserToAddRows = false;
            dtListaProdutos.AllowUserToDeleteRows = false;
            dtListaProdutos.AllowUserToResizeRows = false;
            dtListaProdutos.BackgroundColor = Color.White;
            dtListaProdutos.BorderStyle = BorderStyle.None;
            dtListaProdutos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtListaProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(246, 247, 251);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(246, 247, 251);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtListaProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtListaProdutos.Columns.AddRange(new DataGridViewColumn[] { Imagem, Nome, Qtd, Valor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 70, 77);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 70, 77);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtListaProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            dtListaProdutos.Enabled = false;
            dtListaProdutos.EnableHeadersVisualStyles = false;
            dtListaProdutos.Location = new Point(33, 90);
            dtListaProdutos.MultiSelect = false;
            dtListaProdutos.Name = "dtListaProdutos";
            dtListaProdutos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Control;
            dtListaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtListaProdutos.RowHeadersVisible = false;
            dtListaProdutos.RowTemplate.Height = 50;
            dtListaProdutos.RowTemplate.ReadOnly = true;
            dtListaProdutos.RowTemplate.Resizable = DataGridViewTriState.False;
            dtListaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtListaProdutos.Size = new Size(800, 305);
            dtListaProdutos.StandardTab = true;
            dtListaProdutos.TabIndex = 30;
            // 
            // lblCodVenda
            // 
            lblCodVenda.AutoSize = true;
            lblCodVenda.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodVenda.ForeColor = Color.FromArgb(64, 70, 77);
            lblCodVenda.Location = new Point(434, 37);
            lblCodVenda.Name = "lblCodVenda";
            lblCodVenda.Size = new Size(173, 32);
            lblCodVenda.TabIndex = 9;
            lblCodVenda.Text = "Operação:0001";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.ForeColor = Color.FromArgb(64, 70, 77);
            lblData.Location = new Point(33, 25);
            lblData.Name = "lblData";
            lblData.Size = new Size(183, 47);
            lblData.TabIndex = 8;
            lblData.Text = "Data/Hora";
            // 
            // pUltimoItem
            // 
            pUltimoItem.BackColor = Color.White;
            pUltimoItem.Controls.Add(pBottom);
            pUltimoItem.Controls.Add(lblProduto);
            pUltimoItem.Controls.Add(lblPreco);
            pUltimoItem.Controls.Add(pbImg);
            pUltimoItem.Dock = DockStyle.Bottom;
            pUltimoItem.Location = new Point(0, 421);
            pUltimoItem.Name = "pUltimoItem";
            pUltimoItem.Size = new Size(945, 259);
            pUltimoItem.TabIndex = 8;
            // 
            // pBottom
            // 
            pBottom.BackColor = Color.FromArgb(37, 77, 113);
            pBottom.Controls.Add(tbCodBar);
            pBottom.Controls.Add(tbNum);
            pBottom.Controls.Add(tbQtd);
            pBottom.Location = new Point(0, 187);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(945, 40);
            pBottom.TabIndex = 48;
            // 
            // tbCodBar
            // 
            tbCodBar.BackColor = Color.FromArgb(37, 77, 113);
            tbCodBar.BorderStyle = BorderStyle.None;
            tbCodBar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCodBar.ForeColor = Color.White;
            tbCodBar.Location = new Point(33, 9);
            tbCodBar.Name = "tbCodBar";
            tbCodBar.RightToLeft = RightToLeft.Yes;
            tbCodBar.Size = new Size(333, 22);
            tbCodBar.TabIndex = 1;
            tbCodBar.Text = "cod. barras";
            tbCodBar.Enter += tbCodBar_Enter;
            tbCodBar.KeyDown += tbCodBar_KeyDown;
            tbCodBar.Leave += tbCodBar_Leave;
            // 
            // tbNum
            // 
            tbNum.BackColor = Color.FromArgb(37, 77, 113);
            tbNum.BorderStyle = BorderStyle.None;
            tbNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNum.ForeColor = Color.White;
            tbNum.Location = new Point(408, 9);
            tbNum.Name = "tbNum";
            tbNum.RightToLeft = RightToLeft.Yes;
            tbNum.Size = new Size(100, 22);
            tbNum.TabIndex = 2;
            tbNum.Text = "núm";
            tbNum.Enter += tbNum_Enter;
            tbNum.KeyDown += tbNum_KeyDown;
            tbNum.Leave += tbNum_Leave;
            // 
            // tbQtd
            // 
            tbQtd.BackColor = Color.FromArgb(37, 77, 113);
            tbQtd.BorderStyle = BorderStyle.None;
            tbQtd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbQtd.ForeColor = Color.White;
            tbQtd.Location = new Point(542, 9);
            tbQtd.Name = "tbQtd";
            tbQtd.RightToLeft = RightToLeft.Yes;
            tbQtd.Size = new Size(100, 22);
            tbQtd.TabIndex = 3;
            tbQtd.Text = "qtd";
            tbQtd.Enter += tbQtd_Enter;
            tbQtd.KeyDown += tbQtd_KeyDown;
            tbQtd.Leave += tbQtd_Leave;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.FromArgb(64, 70, 77);
            lblProduto.Location = new Point(208, 43);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(96, 40);
            lblProduto.TabIndex = 40;
            lblProduto.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco.ForeColor = Color.FromArgb(64, 70, 77);
            lblPreco.Location = new Point(208, 100);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(88, 40);
            lblPreco.TabIndex = 39;
            lblPreco.Text = "Preço";
            // 
            // pbImg
            // 
            pbImg.Image = (Image)resources.GetObject("pbImg.Image");
            pbImg.Location = new Point(3, 3);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(184, 184);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 38;
            pbImg.TabStop = false;
            // 
            // Imagem
            // 
            Imagem.HeaderText = "Imagem";
            Imagem.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Imagem.Name = "Imagem";
            Imagem.ReadOnly = true;
            Imagem.Resizable = DataGridViewTriState.False;
            Imagem.Width = 75;
            // 
            // Nome
            // 
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Nome.DefaultCellStyle = dataGridViewCellStyle2;
            Nome.HeaderText = "Produto";
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            Nome.Width = 500;
            // 
            // Qtd
            // 
            Qtd.HeaderText = "Qtd.";
            Qtd.Name = "Qtd";
            Qtd.ReadOnly = true;
            Qtd.Width = 75;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor un.";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            Valor.Width = 150;
            // 
            // fVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 680);
            Controls.Add(pUltimoItem);
            Controls.Add(pLista);
            Controls.Add(pInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fVendas";
            Text = "BKP";
            KeyDown += tbCodBar_KeyDown;
            pInfo.ResumeLayout(false);
            pInfo.PerformLayout();
            pLista.ResumeLayout(false);
            pLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtListaProdutos).EndInit();
            pUltimoItem.ResumeLayout(false);
            pUltimoItem.PerformLayout();
            pBottom.ResumeLayout(false);
            pBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pInfo;
        private Label lblValorTotal;
        private Label lblValorParcial;
        private Label lblDesc;
        private Label lblNumItens;
        private Panel pLista;
        public DataGridView dtListaProdutos;
        private Label lblCodVenda;
        private Label lblData;
        private Panel pUltimoItem;
        private Label lblProduto;
        private Label lblPreco;
        private PictureBox pbImg;
        private Panel pBottom;
        public TextBox tbCodBar;
        private TextBox tbNum;
        private TextBox tbQtd;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Valor;
    }
}