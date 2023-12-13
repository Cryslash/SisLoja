namespace SisLoja.UI
{
    partial class popTipoPagamento
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
            pSkin = new Panel();
            lblDebito = new Label();
            lblCredito = new Label();
            lblPix = new Label();
            lblDinheiro = new Label();
            pSkin.SuspendLayout();
            SuspendLayout();
            // 
            // pSkin
            // 
            pSkin.BackColor = Color.FromArgb(37, 77, 113);
            pSkin.Controls.Add(lblDebito);
            pSkin.Controls.Add(lblCredito);
            pSkin.Controls.Add(lblPix);
            pSkin.Controls.Add(lblDinheiro);
            pSkin.Dock = DockStyle.Fill;
            pSkin.ForeColor = Color.White;
            pSkin.Location = new Point(0, 0);
            pSkin.Name = "pSkin";
            pSkin.Size = new Size(387, 228);
            pSkin.TabIndex = 1;
            // 
            // lblDebito
            // 
            lblDebito.AutoSize = true;
            lblDebito.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDebito.Location = new Point(48, 170);
            lblDebito.Name = "lblDebito";
            lblDebito.Size = new Size(202, 30);
            lblDebito.TabIndex = 17;
            lblDebito.Text = "4 - Cartão de Débito";
            lblDebito.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCredito
            // 
            lblCredito.AutoSize = true;
            lblCredito.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCredito.Location = new Point(48, 123);
            lblCredito.Name = "lblCredito";
            lblCredito.Size = new Size(207, 30);
            lblCredito.TabIndex = 16;
            lblCredito.Text = "3 - Cartão de Crédito";
            lblCredito.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPix
            // 
            lblPix.AutoSize = true;
            lblPix.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPix.Location = new Point(48, 76);
            lblPix.Name = "lblPix";
            lblPix.Size = new Size(71, 30);
            lblPix.TabIndex = 15;
            lblPix.Text = "2 - Pix";
            lblPix.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDinheiro
            // 
            lblDinheiro.AutoSize = true;
            lblDinheiro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDinheiro.Location = new Point(48, 29);
            lblDinheiro.Name = "lblDinheiro";
            lblDinheiro.Size = new Size(123, 30);
            lblDinheiro.TabIndex = 14;
            lblDinheiro.Text = "1 - Dinheiro";
            lblDinheiro.TextAlign = ContentAlignment.TopCenter;
            // 
            // popTipoPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 228);
            Controls.Add(pSkin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "popTipoPagamento";
            StateActive.Back.Color1 = Color.FromArgb(37, 77, 113);
            StateActive.Back.Color2 = Color.FromArgb(37, 77, 113);
            StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateActive.Border.Rounding = 25F;
            StateCommon.Back.Color1 = Color.FromArgb(37, 77, 113);
            StateCommon.Back.Color2 = Color.FromArgb(37, 77, 113);
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 25F;
            StateInactive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateInactive.Border.Rounding = 25F;
            Text = "popTipoPagamento";
            FormClosing += popTipoPagamento_FormClosing;
            KeyDown += popTipoPagamento_KeyDown;
            pSkin.ResumeLayout(false);
            pSkin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pSkin;
        private Label lblDebito;
        private Label lblCredito;
        private Label lblPix;
        private Label lblDinheiro;
    }
}