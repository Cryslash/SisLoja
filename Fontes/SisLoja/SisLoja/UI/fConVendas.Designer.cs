namespace SisLoja.UI
{
    partial class fConVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConVendas));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            ktbPesquisar = new Krypton.Toolkit.KryptonTextBox();
            dtVendas = new DataGridView();
            kbtnVoltar = new Krypton.Toolkit.KryptonButton();
            kbtnTrocar = new Krypton.Toolkit.KryptonButton();
            kbtnCancelar = new Krypton.Toolkit.KryptonButton();
            kbtnConfirmar = new Krypton.Toolkit.KryptonButton();
            kbtnEstornar = new Krypton.Toolkit.KryptonButton();
            dtProdutos = new DataGridView();
            label1 = new Label();
            ktbCodeBar = new Krypton.Toolkit.KryptonTextBox();
            ktbNum = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtVendas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtProdutos).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1106, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 63;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(37, 77, 113);
            label10.Location = new Point(117, 56);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 62;
            label10.Text = "Vendas";
            // 
            // ktbPesquisar
            // 
            ktbPesquisar.Location = new Point(871, 54);
            ktbPesquisar.Name = "ktbPesquisar";
            ktbPesquisar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbPesquisar.Size = new Size(229, 29);
            ktbPesquisar.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbPesquisar.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbPesquisar.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbPesquisar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPesquisar.StateActive.Border.Rounding = 20F;
            ktbPesquisar.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbPesquisar.StateActive.Content.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ktbPesquisar.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbPesquisar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPesquisar.StateDisabled.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbPesquisar.StateDisabled.Border.Color1 = Color.FromArgb(242, 241, 242);
            ktbPesquisar.StateDisabled.Border.Color2 = Color.FromArgb(242, 241, 242);
            ktbPesquisar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPesquisar.StateDisabled.Border.Rounding = 20F;
            ktbPesquisar.StateDisabled.Content.Color1 = Color.Gray;
            ktbPesquisar.StateDisabled.Content.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ktbPesquisar.StateDisabled.Content.Padding = new Padding(10, -1, -1, -1);
            ktbPesquisar.TabIndex = 61;
            ktbPesquisar.TextChanged += ktbPesquisar_TextChanged;
            // 
            // dtVendas
            // 
            dtVendas.AllowUserToAddRows = false;
            dtVendas.AllowUserToDeleteRows = false;
            dtVendas.AllowUserToResizeRows = false;
            dtVendas.BackgroundColor = Color.White;
            dtVendas.BorderStyle = BorderStyle.None;
            dtVendas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtVendas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtVendas.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(147, 147, 147);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtVendas.DefaultCellStyle = dataGridViewCellStyle2;
            dtVendas.EnableHeadersVisualStyles = false;
            dtVendas.Location = new Point(66, 148);
            dtVendas.MultiSelect = false;
            dtVendas.Name = "dtVendas";
            dtVendas.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dtVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtVendas.RowHeadersVisible = false;
            dtVendas.RowTemplate.Height = 35;
            dtVendas.RowTemplate.ReadOnly = true;
            dtVendas.RowTemplate.Resizable = DataGridViewTriState.False;
            dtVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtVendas.Size = new Size(1066, 212);
            dtVendas.StandardTab = true;
            dtVendas.TabIndex = 65;
            dtVendas.Click += dtVendas_Click;
            // 
            // kbtnVoltar
            // 
            kbtnVoltar.Cursor = Cursors.Hand;
            kbtnVoltar.Location = new Point(66, 602);
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
            kbtnVoltar.TabIndex = 70;
            kbtnVoltar.Values.Image = (Image)resources.GetObject("kbtnVoltar.Values.Image");
            kbtnVoltar.Values.Text = "Voltar";
            kbtnVoltar.Click += kbtnVoltar_Click;
            // 
            // kbtnTrocar
            // 
            kbtnTrocar.Cursor = Cursors.Hand;
            kbtnTrocar.Enabled = false;
            kbtnTrocar.Location = new Point(394, 602);
            kbtnTrocar.Name = "kbtnTrocar";
            kbtnTrocar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnTrocar.Size = new Size(136, 40);
            kbtnTrocar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnTrocar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnTrocar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnTrocar.StateCommon.Border.Rounding = 15F;
            kbtnTrocar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnTrocar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnTrocar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnTrocar.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbtnTrocar.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbtnTrocar.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbtnTrocar.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbtnTrocar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnTrocar.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbtnTrocar.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbtnTrocar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnTrocar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnTrocar.TabIndex = 69;
            kbtnTrocar.Values.Image = (Image)resources.GetObject("kbtnTrocar.Values.Image");
            kbtnTrocar.Values.ImageStates.ImageCheckedNormal = null;
            kbtnTrocar.Values.ImageStates.ImageCheckedPressed = null;
            kbtnTrocar.Values.ImageStates.ImageCheckedTracking = null;
            kbtnTrocar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbtnTrocar.Values.ImageStates.ImageDisabled");
            kbtnTrocar.Values.Text = "Troca";
            kbtnTrocar.Click += kbtnTrocar_Click;
            // 
            // kbtnCancelar
            // 
            kbtnCancelar.Cursor = Cursors.Hand;
            kbtnCancelar.Enabled = false;
            kbtnCancelar.Location = new Point(590, 602);
            kbtnCancelar.Name = "kbtnCancelar";
            kbtnCancelar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnCancelar.Size = new Size(136, 40);
            kbtnCancelar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnCancelar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnCancelar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnCancelar.StateCommon.Border.Rounding = 15F;
            kbtnCancelar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnCancelar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnCancelar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnCancelar.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbtnCancelar.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbtnCancelar.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbtnCancelar.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbtnCancelar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnCancelar.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbtnCancelar.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbtnCancelar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnCancelar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnCancelar.TabIndex = 67;
            kbtnCancelar.Values.Image = (Image)resources.GetObject("kbtnCancelar.Values.Image");
            kbtnCancelar.Values.ImageStates.ImageCheckedNormal = null;
            kbtnCancelar.Values.ImageStates.ImageCheckedPressed = null;
            kbtnCancelar.Values.ImageStates.ImageCheckedTracking = null;
            kbtnCancelar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbtnCancelar.Values.ImageStates.ImageDisabled");
            kbtnCancelar.Values.Text = "Cancelar";
            kbtnCancelar.Click += kbtnCancelar_Click;
            // 
            // kbtnConfirmar
            // 
            kbtnConfirmar.Cursor = Cursors.Hand;
            kbtnConfirmar.Enabled = false;
            kbtnConfirmar.Location = new Point(735, 602);
            kbtnConfirmar.Name = "kbtnConfirmar";
            kbtnConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnConfirmar.Size = new Size(136, 40);
            kbtnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnConfirmar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnConfirmar.StateCommon.Border.Rounding = 15F;
            kbtnConfirmar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnConfirmar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnConfirmar.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbtnConfirmar.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbtnConfirmar.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbtnConfirmar.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbtnConfirmar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnConfirmar.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbtnConfirmar.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbtnConfirmar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnConfirmar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnConfirmar.TabIndex = 66;
            kbtnConfirmar.Values.Image = (Image)resources.GetObject("kbtnConfirmar.Values.Image");
            kbtnConfirmar.Values.ImageStates.ImageCheckedNormal = null;
            kbtnConfirmar.Values.ImageStates.ImageCheckedPressed = null;
            kbtnConfirmar.Values.ImageStates.ImageCheckedTracking = null;
            kbtnConfirmar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbtnConfirmar.Values.ImageStates.ImageDisabled");
            kbtnConfirmar.Values.Text = "Confirmar";
            // 
            // kbtnEstornar
            // 
            kbtnEstornar.Cursor = Cursors.Hand;
            kbtnEstornar.Enabled = false;
            kbtnEstornar.Location = new Point(249, 602);
            kbtnEstornar.Name = "kbtnEstornar";
            kbtnEstornar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnEstornar.Size = new Size(136, 40);
            kbtnEstornar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            kbtnEstornar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnEstornar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnEstornar.StateCommon.Border.Rounding = 15F;
            kbtnEstornar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnEstornar.StateCommon.Content.ShortText.Color1 = Color.White;
            kbtnEstornar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            kbtnEstornar.StateDisabled.Back.Color1 = Color.FromArgb(147, 147, 147);
            kbtnEstornar.StateDisabled.Back.Color2 = Color.FromArgb(147, 147, 147);
            kbtnEstornar.StateDisabled.Border.Color1 = Color.FromArgb(147, 147, 147);
            kbtnEstornar.StateDisabled.Border.Color2 = Color.FromArgb(147, 147, 147);
            kbtnEstornar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnEstornar.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(51, 51, 51);
            kbtnEstornar.StateDisabled.Content.ShortText.Color2 = Color.FromArgb(51, 51, 51);
            kbtnEstornar.StateTracking.Back.Color1 = Color.FromArgb(80, 60, 90);
            kbtnEstornar.StateTracking.Back.Color2 = Color.FromArgb(80, 60, 90);
            kbtnEstornar.TabIndex = 68;
            kbtnEstornar.Values.Image = (Image)resources.GetObject("kbtnEstornar.Values.Image");
            kbtnEstornar.Values.ImageStates.ImageCheckedNormal = null;
            kbtnEstornar.Values.ImageStates.ImageCheckedPressed = null;
            kbtnEstornar.Values.ImageStates.ImageCheckedTracking = null;
            kbtnEstornar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbtnEstornar.Values.ImageStates.ImageDisabled");
            kbtnEstornar.Values.Text = "Estornar";
            kbtnEstornar.Click += kbtnEstornar_Click;
            // 
            // dtProdutos
            // 
            dtProdutos.AllowUserToAddRows = false;
            dtProdutos.AllowUserToDeleteRows = false;
            dtProdutos.AllowUserToResizeRows = false;
            dtProdutos.BackgroundColor = Color.White;
            dtProdutos.BorderStyle = BorderStyle.None;
            dtProdutos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtProdutos.Cursor = Cursors.Hand;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(147, 147, 147);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtProdutos.DefaultCellStyle = dataGridViewCellStyle5;
            dtProdutos.EnableHeadersVisualStyles = false;
            dtProdutos.Location = new Point(66, 397);
            dtProdutos.MultiSelect = false;
            dtProdutos.Name = "dtProdutos";
            dtProdutos.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.Control;
            dtProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtProdutos.RowHeadersVisible = false;
            dtProdutos.RowTemplate.Height = 35;
            dtProdutos.RowTemplate.ReadOnly = true;
            dtProdutos.RowTemplate.Resizable = DataGridViewTriState.False;
            dtProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtProdutos.Size = new Size(469, 165);
            dtProdutos.StandardTab = true;
            dtProdutos.TabIndex = 71;
            dtProdutos.Click += dtProdutos_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(590, 397);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 72;
            label1.Text = "Cód. Barra";
            // 
            // ktbCodeBar
            // 
            ktbCodeBar.Enabled = false;
            ktbCodeBar.Location = new Point(590, 421);
            ktbCodeBar.Name = "ktbCodeBar";
            ktbCodeBar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbCodeBar.Size = new Size(222, 36);
            ktbCodeBar.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbCodeBar.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbCodeBar.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbCodeBar.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCodeBar.StateActive.Border.Rounding = 20F;
            ktbCodeBar.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbCodeBar.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCodeBar.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbCodeBar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCodeBar.StateDisabled.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbCodeBar.StateDisabled.Border.Color1 = Color.FromArgb(242, 241, 242);
            ktbCodeBar.StateDisabled.Border.Color2 = Color.FromArgb(242, 241, 242);
            ktbCodeBar.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbCodeBar.StateDisabled.Border.Rounding = 20F;
            ktbCodeBar.StateDisabled.Content.Color1 = Color.Gray;
            ktbCodeBar.StateDisabled.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbCodeBar.TabIndex = 73;
            ktbCodeBar.KeyDown += ktbCodeBar_KeyDown;
            // 
            // ktbNum
            // 
            ktbNum.Enabled = false;
            ktbNum.Location = new Point(590, 494);
            ktbNum.Name = "ktbNum";
            ktbNum.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbNum.Size = new Size(138, 36);
            ktbNum.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbNum.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbNum.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbNum.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNum.StateActive.Border.Rounding = 20F;
            ktbNum.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbNum.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbNum.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbNum.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNum.StateDisabled.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbNum.StateDisabled.Border.Color1 = Color.FromArgb(242, 241, 242);
            ktbNum.StateDisabled.Border.Color2 = Color.FromArgb(242, 241, 242);
            ktbNum.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNum.StateDisabled.Border.Rounding = 20F;
            ktbNum.StateDisabled.Content.Color1 = Color.Gray;
            ktbNum.StateDisabled.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbNum.TabIndex = 75;
            ktbNum.KeyDown += ktbNum_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(590, 470);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 74;
            label2.Text = "Número";
            // 
            // fConVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1250, 680);
            Controls.Add(ktbNum);
            Controls.Add(label2);
            Controls.Add(ktbCodeBar);
            Controls.Add(label1);
            Controls.Add(dtProdutos);
            Controls.Add(kbtnVoltar);
            Controls.Add(kbtnTrocar);
            Controls.Add(kbtnCancelar);
            Controls.Add(kbtnConfirmar);
            Controls.Add(kbtnEstornar);
            Controls.Add(dtVendas);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(ktbPesquisar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fConVendas";
            Text = "fConVendas";
            Load += fConVendas_Load;
            Shown += fConVendas_Shown;
            Click += fConVendas_Click;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtVendas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label10;
        public Krypton.Toolkit.KryptonTextBox ktbPesquisar;
        public DataGridView dtVendas;
        private Krypton.Toolkit.KryptonButton kbtnVoltar;
        private Krypton.Toolkit.KryptonButton kbtnTrocar;
        private Krypton.Toolkit.KryptonButton kbtnCancelar;
        private Krypton.Toolkit.KryptonButton kbtnConfirmar;
        private Krypton.Toolkit.KryptonButton kbtnEstornar;
        public DataGridView dtProdutos;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox ktbCodeBar;
        private Krypton.Toolkit.KryptonTextBox ktbNum;
        private Label label2;
    }
}