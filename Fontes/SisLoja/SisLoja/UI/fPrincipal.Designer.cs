namespace SisLoja
{
    partial class fPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipal));
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.pSkin = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Image = ((System.Drawing.Image)(resources.GetObject("buttonSpecAny1.Image")));
            this.buttonSpecAny1.Orientation = Krypton.Toolkit.PaletteButtonOrientation.FixedLeft;
            this.buttonSpecAny1.UniqueName = "b50ce07b8680498199215f2716f48d3c";
            // 
            // pSkin
            // 
            this.pSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(242)))));
            this.pSkin.Location = new System.Drawing.Point(0, -1);
            this.pSkin.Name = "pSkin";
            this.pSkin.Size = new System.Drawing.Size(1350, 729);
            this.pSkin.TabIndex = 6;
            this.pSkin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSkin_MouseDown);
            this.pSkin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pSkin_MouseMove);
            // 
            // fPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pSkin);
            this.CornerRoundingRadius = 25F;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 25F;
            this.Load += new System.EventHandler(this.fPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        public Panel pSkin;
    }
}