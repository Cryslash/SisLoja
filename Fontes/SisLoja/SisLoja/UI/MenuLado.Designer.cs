namespace SisLoja.UI
{
    partial class MenuLado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLado));
            pSkin = new Panel();
            btnClose = new Button();
            btnSales = new Button();
            btnConsultar = new Button();
            btnCadastrar = new Button();
            btnHome = new Button();
            pSkin.SuspendLayout();
            SuspendLayout();
            // 
            // pSkin
            // 
            pSkin.BackColor = Color.FromArgb(37, 77, 113);
            pSkin.Controls.Add(btnClose);
            pSkin.Controls.Add(btnSales);
            pSkin.Controls.Add(btnConsultar);
            pSkin.Controls.Add(btnCadastrar);
            pSkin.Controls.Add(btnHome);
            pSkin.Dock = DockStyle.Fill;
            pSkin.Location = new Point(0, 0);
            pSkin.Name = "pSkin";
            pSkin.Size = new Size(44, 702);
            pSkin.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(37, 77, 113);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(5, 628);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 8;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSales
            // 
            btnSales.BackColor = Color.FromArgb(37, 77, 113);
            btnSales.Cursor = Cursors.Hand;
            btnSales.FlatAppearance.BorderSize = 0;
            btnSales.FlatStyle = FlatStyle.Flat;
            btnSales.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSales.ForeColor = Color.White;
            btnSales.Image = (Image)resources.GetObject("btnSales.Image");
            btnSales.Location = new Point(5, 390);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(32, 32);
            btnSales.TabIndex = 7;
            btnSales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(37, 77, 113);
            btnConsultar.Cursor = Cursors.Hand;
            btnConsultar.FlatAppearance.BorderSize = 0;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(5, 311);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(32, 32);
            btnConsultar.TabIndex = 6;
            btnConsultar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(37, 77, 113);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatAppearance.BorderSize = 0;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Image = (Image)resources.GetObject("btnCadastrar.Image");
            btnCadastrar.Location = new Point(5, 224);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(32, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(37, 77, 113);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.Casa_32;
            btnHome.Location = new Point(5, 136);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(32, 32);
            btnHome.TabIndex = 4;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // MenuLado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(44, 702);
            Controls.Add(pSkin);
            CornerRoundingRadius = 25F;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuLado";
            StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            StateCommon.Border.Rounding = 25F;
            pSkin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pSkin;
        private Button btnSales;
        private Button btnConsultar;
        public Button btnCadastrar;
        private Button btnHome;
        private Button btnClose;
    }
}