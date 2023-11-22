﻿namespace SisLoja.UI
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVendas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pInfo = new Panel();
            kbnFinalizar = new Krypton.Toolkit.KryptonButton();
            kbnTipoPagamento = new Krypton.Toolkit.KryptonButton();
            kbnDesconto = new Krypton.Toolkit.KryptonButton();
            kbtnCliente = new Krypton.Toolkit.KryptonButton();
            lblValorTotal = new Label();
            lblValorParcial = new Label();
            lblDesc = new Label();
            lblNumItens = new Label();
            pLista = new Panel();
            lblCliente = new Label();
            lblData = new Label();
            dtListaProdutos = new DataGridView();
            Imagem = new DataGridViewImageColumn();
            Nome = new DataGridViewTextBoxColumn();
            Qtd = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            lblCodVenda = new Label();
            lblHoras = new Label();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            pUltimoItem = new Panel();
            pBottom = new Panel();
            tbCodBar = new TextBox();
            tbNum = new TextBox();
            tbQtd = new TextBox();
            lblProduto = new Label();
            lblPreco = new Label();
            pbImg = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
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
            pInfo.Controls.Add(kbnFinalizar);
            pInfo.Controls.Add(kbnTipoPagamento);
            pInfo.Controls.Add(kbnDesconto);
            pInfo.Controls.Add(kbtnCliente);
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
            // kbnFinalizar
            // 
            kbnFinalizar.Cursor = Cursors.Hand;
            kbnFinalizar.Enabled = false;
            kbnFinalizar.Location = new Point(40, 608);
            kbnFinalizar.Name = "kbnFinalizar";
            kbnFinalizar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbnFinalizar.Size = new Size(224, 40);
            kbnFinalizar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbnFinalizar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnFinalizar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbnFinalizar.StateCommon.Border.Rounding = 15F;
            kbnFinalizar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbnFinalizar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbnFinalizar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbnFinalizar.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbnFinalizar.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbnFinalizar.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbnFinalizar.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbnFinalizar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnFinalizar.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbnFinalizar.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbnFinalizar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbnFinalizar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbnFinalizar.TabIndex = 17;
            kbnFinalizar.Values.Image = (Image)resources.GetObject("kbnFinalizar.Values.Image");
            kbnFinalizar.Values.ImageStates.ImageCheckedNormal = null;
            kbnFinalizar.Values.ImageStates.ImageCheckedPressed = null;
            kbnFinalizar.Values.ImageStates.ImageCheckedTracking = null;
            kbnFinalizar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbnFinalizar.Values.ImageStates.ImageDisabled");
            kbnFinalizar.Values.Text = "Finalizar Venda [F5]";
            // 
            // kbnTipoPagamento
            // 
            kbnTipoPagamento.Cursor = Cursors.Hand;
            kbnTipoPagamento.Location = new Point(40, 547);
            kbnTipoPagamento.Name = "kbnTipoPagamento";
            kbnTipoPagamento.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbnTipoPagamento.Size = new Size(224, 40);
            kbnTipoPagamento.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbnTipoPagamento.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnTipoPagamento.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbnTipoPagamento.StateCommon.Border.Rounding = 15F;
            kbnTipoPagamento.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbnTipoPagamento.StateCommon.Content.ShortText.Color1 = Color.White;
            kbnTipoPagamento.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbnTipoPagamento.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbnTipoPagamento.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbnTipoPagamento.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbnTipoPagamento.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbnTipoPagamento.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnTipoPagamento.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbnTipoPagamento.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbnTipoPagamento.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbnTipoPagamento.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbnTipoPagamento.TabIndex = 16;
            kbnTipoPagamento.Values.Image = (Image)resources.GetObject("kbnTipoPagamento.Values.Image");
            kbnTipoPagamento.Values.Text = "Forma Pagamento [F4]";
            // 
            // kbnDesconto
            // 
            kbnDesconto.Cursor = Cursors.Hand;
            kbnDesconto.Location = new Point(40, 482);
            kbnDesconto.Name = "kbnDesconto";
            kbnDesconto.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnDesconto.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnDesconto.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbnDesconto.Size = new Size(224, 40);
            kbnDesconto.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbnDesconto.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbnDesconto.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbnDesconto.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbnDesconto.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnDesconto.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbnDesconto.StateCommon.Border.Rounding = 15F;
            kbnDesconto.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbnDesconto.StateCommon.Content.ShortText.Color1 = Color.White;
            kbnDesconto.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbnDesconto.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbnDesconto.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbnDesconto.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbnDesconto.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbnDesconto.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbnDesconto.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbnDesconto.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbnDesconto.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbnDesconto.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbnDesconto.TabIndex = 15;
            kbnDesconto.Values.Image = (Image)resources.GetObject("kbnDesconto.Values.Image");
            kbnDesconto.Values.Text = "Descontos [F3]";
            // 
            // kbtnCliente
            // 
            kbtnCliente.Cursor = Cursors.Hand;
            kbtnCliente.Location = new Point(40, 421);
            kbtnCliente.Name = "kbtnCliente";
            kbtnCliente.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCliente.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCliente.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnCliente.Size = new Size(224, 40);
            kbtnCliente.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCliente.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCliente.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCliente.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCliente.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnCliente.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnCliente.StateCommon.Border.Rounding = 15F;
            kbtnCliente.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnCliente.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnCliente.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbtnCliente.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbtnCliente.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbtnCliente.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbtnCliente.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnCliente.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbtnCliente.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbtnCliente.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnCliente.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnCliente.TabIndex = 14;
            kbtnCliente.Values.Image = (Image)resources.GetObject("kbtnCliente.Values.Image");
            kbtnCliente.Values.Text = "Cliente [F2]";
            kbtnCliente.Click += kbtnCliente_Click;
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
            lblValorParcial.Location = new Point(40, 270);
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
            lblDesc.Location = new Point(40, 229);
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
            lblNumItens.Location = new Point(40, 188);
            lblNumItens.Name = "lblNumItens";
            lblNumItens.Size = new Size(152, 25);
            lblNumItens.TabIndex = 0;
            lblNumItens.Text = "Número de Itens";
            // 
            // pLista
            // 
            pLista.BackColor = Color.White;
            pLista.Controls.Add(lblCliente);
            pLista.Controls.Add(lblData);
            pLista.Controls.Add(dtListaProdutos);
            pLista.Controls.Add(lblCodVenda);
            pLista.Controls.Add(lblHoras);
            pLista.Dock = DockStyle.Fill;
            pLista.Location = new Point(0, 0);
            pLista.Name = "pLista";
            pLista.Size = new Size(945, 680);
            pLista.TabIndex = 7;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCliente.ForeColor = Color.FromArgb(64, 70, 77);
            lblCliente.Location = new Point(348, 62);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(205, 25);
            lblCliente.TabIndex = 32;
            lblCliente.Text = "Cliente: não informado";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.ForeColor = Color.FromArgb(64, 70, 77);
            lblData.Location = new Point(33, 62);
            lblData.Name = "lblData";
            lblData.Size = new Size(267, 25);
            lblData.TabIndex = 31;
            lblData.Text = "terça 21 de novembro de 2023";
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
            dtListaProdutos.Location = new Point(33, 102);
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
            dtListaProdutos.Size = new Size(875, 295);
            dtListaProdutos.StandardTab = true;
            dtListaProdutos.TabIndex = 30;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
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
            // lblCodVenda
            // 
            lblCodVenda.AutoSize = true;
            lblCodVenda.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCodVenda.ForeColor = Color.FromArgb(64, 70, 77);
            lblCodVenda.Location = new Point(348, 9);
            lblCodVenda.Name = "lblCodVenda";
            lblCodVenda.Size = new Size(155, 47);
            lblCodVenda.TabIndex = 9;
            lblCodVenda.Text = "#000001";
            // 
            // lblHoras
            // 
            lblHoras.AutoSize = true;
            lblHoras.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoras.ForeColor = Color.FromArgb(64, 70, 77);
            lblHoras.Location = new Point(73, 9);
            lblHoras.Name = "lblHoras";
            lblHoras.Size = new Size(120, 47);
            lblHoras.TabIndex = 8;
            lblHoras.Text = "--:--:--";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonSpecs.DropDown.ColorMap = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateNormal.Back.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateNormal.Border.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonCustom1.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color1 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Back.Color2 = Color.FromArgb(37, 77, 113);
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormCustom1.StateActive.Border.Rounding = 25F;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
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
            lblProduto.Size = new Size(120, 40);
            lblProduto.TabIndex = 40;
            lblProduto.Text = "Produto";
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
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
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
            Load += fVendas_Load;
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
        private Label lblHoras;
        private Panel pUltimoItem;
        private Label lblProduto;
        private Label lblPreco;
        private PictureBox pbImg;
        public TextBox tbCodBar;
        private TextBox tbNum;
        private TextBox tbQtd;
        private System.Windows.Forms.Timer timer;
        private Label lblData;
        private Krypton.Toolkit.KryptonButton kbnFinalizar;
        private Krypton.Toolkit.KryptonButton kbnTipoPagamento;
        private Krypton.Toolkit.KryptonButton kbnDesconto;
        private Krypton.Toolkit.KryptonButton kbtnCliente;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private DataGridViewImageColumn Imagem;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Qtd;
        private DataGridViewTextBoxColumn Valor;
        public Label lblCliente;
        public Panel pBottom;
    }
}