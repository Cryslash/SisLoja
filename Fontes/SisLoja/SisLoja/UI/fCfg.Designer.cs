namespace SisLoja.UI
{
    partial class fCfg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCfg));
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            kcbPrinter = new Krypton.Toolkit.KryptonComboBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            ktbPort = new Krypton.Toolkit.KryptonTextBox();
            kbtnSalvar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kcbPrinter).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(37, 77, 113);
            label10.Location = new Point(120, 68);
            label10.Name = "label10";
            label10.Size = new Size(124, 23);
            label10.TabIndex = 40;
            label10.Text = "Configurações";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(37, 77, 113);
            label1.Location = new Point(169, 373);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 42;
            label1.Text = "Dispositivos";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 364);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 43;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(120, 466);
            label2.Name = "label2";
            label2.Size = new Size(88, 21);
            label2.TabIndex = 44;
            label2.Text = "Impressora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(120, 520);
            label3.Name = "label3";
            label3.Size = new Size(139, 42);
            label3.TabIndex = 45;
            label3.Text = "Endereço da Porta \r\nCOM/Moderninha";
            // 
            // kcbPrinter
            // 
            kcbPrinter.Cursor = Cursors.Hand;
            kcbPrinter.DropButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            kcbPrinter.DropDownHeight = 600;
            kcbPrinter.DropDownWidth = 121;
            kcbPrinter.IntegralHeight = false;
            kcbPrinter.Location = new Point(282, 448);
            kcbPrinter.MaxDropDownItems = 30;
            kcbPrinter.Name = "kcbPrinter";
            kcbPrinter.Palette = kryptonCustomPaletteBase1;
            kcbPrinter.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kcbPrinter.Size = new Size(308, 39);
            kcbPrinter.StateActive.ComboBox.Back.Color1 = Color.FromArgb(37, 77, 113);
            kcbPrinter.StateActive.ComboBox.Border.Color1 = Color.FromArgb(37, 77, 113);
            kcbPrinter.StateActive.ComboBox.Border.Color2 = Color.FromArgb(37, 77, 113);
            kcbPrinter.StateActive.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kcbPrinter.StateActive.ComboBox.Border.Rounding = 20F;
            kcbPrinter.StateActive.ComboBox.Content.Color1 = Color.White;
            kcbPrinter.StateActive.ComboBox.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kcbPrinter.StateCommon.ComboBox.Content.Color1 = Color.White;
            kcbPrinter.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kcbPrinter.StateCommon.ComboBox.Content.Padding = new Padding(10, -1, -1, -1);
            kcbPrinter.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kcbPrinter.StateCommon.DropBack.Color1 = Color.FromArgb(37, 77, 113);
            kcbPrinter.StateCommon.DropBack.Color2 = Color.FromArgb(37, 77, 113);
            kcbPrinter.StateCommon.Item.Content.ShortText.Color1 = Color.White;
            kcbPrinter.StateCommon.Item.Content.ShortText.Color2 = Color.White;
            kcbPrinter.StateCommon.Item.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kcbPrinter.StateCommon.Item.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kcbPrinter.TabIndex = 46;
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
            kryptonCustomPaletteBase1.PanelStyles.PanelCommon.StateCommon.Color1 = Color.White;
            kryptonCustomPaletteBase1.PanelStyles.PanelCommon.StateCommon.Color2 = Color.White;
            kryptonCustomPaletteBase1.PanelStyles.PanelCommon.StateNormal.Color1 = Color.White;
            kryptonCustomPaletteBase1.PanelStyles.PanelCommon.StateNormal.Color2 = Color.White;
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // ktbPort
            // 
            ktbPort.Location = new Point(282, 526);
            ktbPort.Name = "ktbPort";
            ktbPort.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbPort.Size = new Size(183, 36);
            ktbPort.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbPort.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbPort.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbPort.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPort.StateActive.Border.Rounding = 20F;
            ktbPort.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbPort.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbPort.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbPort.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbPort.TabIndex = 47;
            // 
            // kbtnSalvar
            // 
            kbtnSalvar.Cursor = Cursors.Hand;
            kbtnSalvar.Location = new Point(469, 592);
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
            kbtnSalvar.TabIndex = 48;
            kbtnSalvar.Values.Image = (Image)resources.GetObject("kbtnSalvar.Values.Image");
            kbtnSalvar.Values.Text = "Salvar";
            // 
            // fCfg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1250, 680);
            Controls.Add(kbtnSalvar);
            Controls.Add(ktbPort);
            Controls.Add(kcbPrinter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fCfg";
            Text = "fCfg";
            Load += fCfg_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kcbPrinter).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label10;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Krypton.Toolkit.KryptonComboBox kcbPrinter;
        public Krypton.Toolkit.KryptonTextBox ktbPort;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton kbtnSalvar;
    }
}