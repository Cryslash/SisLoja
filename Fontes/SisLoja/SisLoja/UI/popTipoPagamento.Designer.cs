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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pSkin.SuspendLayout();
            SuspendLayout();
            // 
            // pSkin
            // 
            pSkin.BackColor = Color.FromArgb(37, 77, 113);
            pSkin.Controls.Add(label4);
            pSkin.Controls.Add(label3);
            pSkin.Controls.Add(label2);
            pSkin.Controls.Add(label1);
            pSkin.Dock = DockStyle.Fill;
            pSkin.ForeColor = Color.White;
            pSkin.Location = new Point(0, 0);
            pSkin.Name = "pSkin";
            pSkin.Size = new Size(387, 228);
            pSkin.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 170);
            label4.Name = "label4";
            label4.Size = new Size(202, 30);
            label4.TabIndex = 17;
            label4.Text = "4 - Cartão de Débito";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 123);
            label3.Name = "label3";
            label3.Size = new Size(207, 30);
            label3.TabIndex = 16;
            label3.Text = "3 - Cartão de Crédito";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 15;
            label2.Text = "2 - Pix";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 14;
            label1.Text = "1 - Dinheiro";
            label1.TextAlign = ContentAlignment.TopCenter;
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
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}