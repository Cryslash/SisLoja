namespace SisLoja.UI
{
    partial class popCliente
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popCliente));
            pSkin = new Panel();
            dtCliente = new DataGridView();
            kbtnConfirmar = new Krypton.Toolkit.KryptonButton();
            ktbNome = new Krypton.Toolkit.KryptonTextBox();
            pSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtCliente).BeginInit();
            SuspendLayout();
            // 
            // pSkin
            // 
            pSkin.BackColor = Color.FromArgb(37, 77, 113);
            pSkin.Controls.Add(dtCliente);
            pSkin.Controls.Add(kbtnConfirmar);
            pSkin.Controls.Add(ktbNome);
            pSkin.Dock = DockStyle.Fill;
            pSkin.ForeColor = Color.White;
            pSkin.Location = new Point(0, 0);
            pSkin.Name = "pSkin";
            pSkin.Size = new Size(403, 267);
            pSkin.TabIndex = 0;
            // 
            // dtCliente
            // 
            dtCliente.AllowUserToAddRows = false;
            dtCliente.AllowUserToDeleteRows = false;
            dtCliente.AllowUserToResizeRows = false;
            dtCliente.BackgroundColor = Color.FromArgb(37, 77, 113);
            dtCliente.BorderStyle = BorderStyle.None;
            dtCliente.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtCliente.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(37, 77, 113);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(147, 147, 147);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dtCliente.EnableHeadersVisualStyles = false;
            dtCliente.Location = new Point(33, 73);
            dtCliente.MultiSelect = false;
            dtCliente.Name = "dtCliente";
            dtCliente.ReadOnly = true;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Control;
            dtCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtCliente.RowHeadersVisible = false;
            dtCliente.RowTemplate.Height = 35;
            dtCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtCliente.Size = new Size(330, 132);
            dtCliente.StandardTab = true;
            dtCliente.TabIndex = 29;
            // 
            // kbtnConfirmar
            // 
            kbtnConfirmar.Cursor = Cursors.Hand;
            kbtnConfirmar.Location = new Point(308, 215);
            kbtnConfirmar.Name = "kbtnConfirmar";
            kbtnConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kbtnConfirmar.Size = new Size(69, 40);
            kbtnConfirmar.StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Border.Color1 = Color.White;
            kbtnConfirmar.StateCommon.Border.Color2 = Color.White;
            kbtnConfirmar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kbtnConfirmar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kbtnConfirmar.StateCommon.Border.Rounding = 15F;
            kbtnConfirmar.StateCommon.Content.Image.ImageV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kbtnConfirmar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(37, 77, 113);
            kbtnConfirmar.StateCommon.Content.ShortText.Color2 = Color.FromArgb(37, 77, 113);
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
            kbtnConfirmar.TabIndex = 13;
            kbtnConfirmar.Values.Image = (Image)resources.GetObject("kbtnConfirmar.Values.Image");
            kbtnConfirmar.Values.ImageStates.ImageCheckedNormal = null;
            kbtnConfirmar.Values.ImageStates.ImageCheckedPressed = null;
            kbtnConfirmar.Values.ImageStates.ImageCheckedTracking = null;
            kbtnConfirmar.Values.ImageStates.ImageDisabled = (Image)resources.GetObject("kbtnConfirmar.Values.ImageStates.ImageDisabled");
            kbtnConfirmar.Values.Text = "";
            kbtnConfirmar.Click += kbtnConfirmar_Click;
            // 
            // ktbNome
            // 
            ktbNome.Location = new Point(21, 27);
            ktbNome.Name = "ktbNome";
            ktbNome.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ktbNome.Size = new Size(356, 36);
            ktbNome.StateActive.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbNome.StateActive.Border.Color1 = Color.FromArgb(224, 224, 224);
            ktbNome.StateActive.Border.Color2 = Color.FromArgb(224, 224, 224);
            ktbNome.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNome.StateActive.Border.Rounding = 20F;
            ktbNome.StateActive.Content.Color1 = Color.FromArgb(51, 51, 51);
            ktbNome.StateActive.Content.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ktbNome.StateActive.Content.Padding = new Padding(10, 0, 10, 0);
            ktbNome.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNome.StateDisabled.Back.Color1 = Color.FromArgb(242, 241, 242);
            ktbNome.StateDisabled.Border.Color1 = Color.FromArgb(242, 241, 242);
            ktbNome.StateDisabled.Border.Color2 = Color.FromArgb(242, 241, 242);
            ktbNome.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ktbNome.StateDisabled.Border.Rounding = 20F;
            ktbNome.TabIndex = 7;
            ktbNome.TextChanged += ktbNome_TextChanged;
            ktbNome.KeyDown += ktbNome_KeyDown;
            // 
            // popCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 267);
            Controls.Add(pSkin);
            CornerRoundingRadius = 25F;
            FormBorderStyle = FormBorderStyle.None;
            Name = "popCliente";
            StateActive.Back.Color1 = Color.FromArgb(37, 77, 113);
            StateActive.Back.Color2 = Color.FromArgb(37, 77, 113);
            StateActive.Border.Color1 = Color.FromArgb(37, 77, 113);
            StateActive.Border.Color2 = Color.FromArgb(37, 77, 113);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 25F;
            StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            StateCommon.Border.Color1 = Color.FromArgb(37, 77, 113);
            StateCommon.Border.Color2 = Color.FromArgb(37, 77, 113);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 25F;
            FormClosing += popCliente_FormClosing;
            KeyDown += popCliente_KeyDown;
            pSkin.ResumeLayout(false);
            pSkin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtCliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSkin;
        private Krypton.Toolkit.KryptonTextBox ktbNome;
        private Krypton.Toolkit.KryptonButton kbtnConfirmar;
        public DataGridView dtCliente;
    }
}