namespace SisLoja.UI
{
    partial class fCadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadProduto));
            pbImg = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pbQrCod = new PictureBox();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            ktbNome = new Krypton.Toolkit.KryptonTextBox();
            ktbModelo = new Krypton.Toolkit.KryptonTextBox();
            ktbRef = new Krypton.Toolkit.KryptonTextBox();
            ktbCor = new Krypton.Toolkit.KryptonTextBox();
            ktbMin = new Krypton.Toolkit.KryptonTextBox();
            ktbPreco = new Krypton.Toolkit.KryptonTextBox();
            ktbQrCode = new Krypton.Toolkit.KryptonTextBox();
            ktbCodBar = new Krypton.Toolkit.KryptonTextBox();
            kbtnVoltar = new Krypton.Toolkit.KryptonButton();
            kbtnSalvar = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            kbtnImg = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbQrCod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.White;
            pbImg.Image = (Image)resources.GetObject("pbImg.Image");
            pbImg.InitialImage = (Image)resources.GetObject("pbImg.InitialImage");
            pbImg.Location = new Point(569, 128);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(224, 224);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 0;
            pbImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(51, 51, 51);
            label1.Location = new Point(241, 200);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 3;
            label1.Text = "Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(51, 51, 51);
            label2.Location = new Point(464, 200);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 5;
            label2.Text = "Modelo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(51, 51, 51);
            label3.Location = new Point(262, 269);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 7;
            label3.Text = "Estoque Mínimo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(51, 51, 51);
            label4.Location = new Point(415, 269);
            label4.Name = "label4";
            label4.Size = new Size(128, 21);
            label4.TabIndex = 9;
            label4.Text = "Preço de Venda";
            // 
            // pbQrCod
            // 
            pbQrCod.Location = new Point(569, 352);
            pbQrCod.Name = "pbQrCod";
            pbQrCod.Size = new Size(224, 224);
            pbQrCod.SizeMode = PictureBoxSizeMode.Zoom;
            pbQrCod.TabIndex = 11;
            pbQrCod.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(51, 51, 51);
            label7.Location = new Point(267, 386);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 16;
            label7.Text = "Referência";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(51, 51, 51);
            label5.Location = new Point(404, 460);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 18;
            label5.Text = "Código de Barras";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(51, 51, 51);
            label6.Location = new Point(485, 386);
            label6.Name = "label6";
            label6.Size = new Size(58, 21);
            label6.TabIndex = 20;
            label6.Text = "QrCod";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(51, 51, 51);
            label8.Location = new Point(206, 268);
            label8.Name = "label8";
            label8.Size = new Size(36, 21);
            label8.TabIndex = 26;
            label8.Text = "Cor";
            // 
            // ktbNome
            // 
            ktbNome.Location = new Point(116, 224);
            ktbNome.Name = "ktbNome";
            ktbNome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbNome.Size = new Size(211, 36);
            ktbNome.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbNome.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbNome.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbNome.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNome.StateActive.Border.Rounding = 20F;
            ktbNome.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbNome.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbNome.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbNome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNome.TabIndex = 2;
            // 
            // ktbModelo
            // 
            ktbModelo.Location = new Point(339, 224);
            ktbModelo.Name = "ktbModelo";
            ktbModelo.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbModelo.Size = new Size(211, 36);
            ktbModelo.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbModelo.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbModelo.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbModelo.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbModelo.StateActive.Border.Rounding = 20F;
            ktbModelo.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbModelo.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbModelo.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbModelo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbModelo.TabIndex = 3;
            // 
            // ktbRef
            // 
            ktbRef.Location = new Point(213, 410);
            ktbRef.Name = "ktbRef";
            ktbRef.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbRef.Size = new Size(152, 36);
            ktbRef.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbRef.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbRef.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbRef.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbRef.StateActive.Border.Rounding = 20F;
            ktbRef.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbRef.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbRef.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbRef.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbRef.TabIndex = 7;
            // 
            // ktbCor
            // 
            ktbCor.Location = new Point(111, 292);
            ktbCor.Name = "ktbCor";
            ktbCor.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbCor.Size = new Size(145, 36);
            ktbCor.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbCor.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbCor.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbCor.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCor.StateActive.Border.Rounding = 20F;
            ktbCor.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbCor.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCor.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbCor.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCor.TabIndex = 4;
            // 
            // ktbMin
            // 
            ktbMin.Location = new Point(262, 292);
            ktbMin.Name = "ktbMin";
            ktbMin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbMin.Size = new Size(144, 36);
            ktbMin.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbMin.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbMin.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbMin.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbMin.StateActive.Border.Rounding = 20F;
            ktbMin.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbMin.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbMin.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbMin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbMin.TabIndex = 5;
            ktbMin.KeyPress += tbMin_KeyPress;
            // 
            // ktbPreco
            // 
            ktbPreco.Location = new Point(415, 290);
            ktbPreco.Name = "ktbPreco";
            ktbPreco.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbPreco.Size = new Size(135, 36);
            ktbPreco.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbPreco.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbPreco.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbPreco.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPreco.StateActive.Border.Rounding = 20F;
            ktbPreco.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbPreco.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbPreco.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbPreco.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPreco.TabIndex = 6;
            ktbPreco.KeyPress += tbPreco_KeyPress;
            // 
            // ktbQrCode
            // 
            ktbQrCode.Location = new Point(371, 410);
            ktbQrCode.Name = "ktbQrCode";
            ktbQrCode.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbQrCode.Size = new Size(179, 36);
            ktbQrCode.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbQrCode.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbQrCode.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbQrCode.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbQrCode.StateActive.Border.Rounding = 20F;
            ktbQrCode.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbQrCode.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbQrCode.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbQrCode.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbQrCode.TabIndex = 8;
            ktbQrCode.Leave += ktbQrCode_Leave;
            // 
            // ktbCodBar
            // 
            ktbCodBar.Location = new Point(284, 484);
            ktbCodBar.Name = "ktbCodBar";
            ktbCodBar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbCodBar.Size = new Size(266, 36);
            ktbCodBar.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbCodBar.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbCodBar.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbCodBar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCodBar.StateActive.Border.Rounding = 20F;
            ktbCodBar.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbCodBar.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCodBar.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbCodBar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCodBar.TabIndex = 9;
            // 
            // kbtnVoltar
            // 
            kbtnVoltar.Cursor = Cursors.Hand;
            kbtnVoltar.Location = new Point(71, 601);
            kbtnVoltar.Name = "kbtnVoltar";
            kbtnVoltar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnVoltar.Size = new Size(121, 40);
            kbtnVoltar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnVoltar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnVoltar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnVoltar.StateCommon.Border.Rounding = 15F;
            kbtnVoltar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnVoltar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnVoltar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnVoltar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnVoltar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnVoltar.TabIndex = 11;
            kbtnVoltar.Values.Image = (Image)resources.GetObject("kbtnVoltar.Values.Image");
            kbtnVoltar.Values.Text = "Voltar";
            kbtnVoltar.Click += btnVoltar_Click;
            // 
            // kbtnSalvar
            // 
            kbtnSalvar.Cursor = Cursors.Hand;
            kbtnSalvar.Location = new Point(213, 601);
            kbtnSalvar.Name = "kbtnSalvar";
            kbtnSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnSalvar.Size = new Size(121, 40);
            kbtnSalvar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnSalvar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnSalvar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnSalvar.StateCommon.Border.Rounding = 15F;
            kbtnSalvar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnSalvar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnSalvar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnSalvar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnSalvar.TabIndex = 10;
            kbtnSalvar.Values.Image = (Image)resources.GetObject("kbtnSalvar.Values.Image");
            kbtnSalvar.Values.Text = "Salvar";
            kbtnSalvar.Click += btnSalvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(37, 77, 113);
            label10.Location = new Point(119, 68);
            label10.Name = "label10";
            label10.Size = new Size(157, 23);
            label10.TabIndex = 38;
            label10.Text = "Cadastrar Produto";
            // 
            // kbtnImg
            // 
            kbtnImg.Cursor = Cursors.Hand;
            kbtnImg.Location = new Point(391, 149);
            kbtnImg.Name = "kbtnImg";
            kbtnImg.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnImg.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnImg.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnImg.Size = new Size(159, 40);
            kbtnImg.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnImg.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnImg.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnImg.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnImg.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnImg.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnImg.StateCommon.Border.Rounding = 15F;
            kbtnImg.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnImg.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnImg.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnImg.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            kbtnImg.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnImg.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnImg.TabIndex = 1;
            kbtnImg.Values.Image = (Image)resources.GetObject("kbtnImg.Values.Image");
            kbtnImg.Values.Text = "Selec. imagem";
            kbtnImg.Click += btnImg_Click;
            // 
            // fCadProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1250, 680);
            Controls.Add(kbtnImg);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(kbtnVoltar);
            Controls.Add(kbtnSalvar);
            Controls.Add(ktbCodBar);
            Controls.Add(ktbQrCode);
            Controls.Add(ktbPreco);
            Controls.Add(ktbMin);
            Controls.Add(ktbCor);
            Controls.Add(ktbRef);
            Controls.Add(ktbModelo);
            Controls.Add(ktbNome);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(pbQrCod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbImg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fCadProduto";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbQrCod).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbQrCod;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label8;
        private Krypton.Toolkit.KryptonTextBox ktbNome;
        private Krypton.Toolkit.KryptonTextBox ktbModelo;
        private Krypton.Toolkit.KryptonTextBox ktbRef;
        private Krypton.Toolkit.KryptonTextBox ktbCor;
        private Krypton.Toolkit.KryptonTextBox ktbMin;
        private Krypton.Toolkit.KryptonTextBox ktbPreco;
        private Krypton.Toolkit.KryptonTextBox ktbQrCode;
        private Krypton.Toolkit.KryptonTextBox ktbCodBar;
        private Krypton.Toolkit.KryptonButton kbtnVoltar;
        private Krypton.Toolkit.KryptonButton kbtnSalvar;
        private PictureBox pictureBox1;
        private Label label10;
        private Krypton.Toolkit.KryptonButton kbtnImg;
    }
}