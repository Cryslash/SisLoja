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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lbllEVEL = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCfg = new System.Windows.Forms.Button();
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pDashArea = new System.Windows.Forms.Panel();
            this.pTitle.SuspendLayout();
            this.pOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(74, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Beauty Moon";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.Location = new System.Drawing.Point(1310, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 32);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.lbllEVEL);
            this.pTitle.Controls.Add(this.lblUser);
            this.pTitle.Controls.Add(this.btnCfg);
            this.pTitle.Controls.Add(this.btnLogoff);
            this.pTitle.Controls.Add(this.btnMinimize);
            this.pTitle.Controls.Add(this.lblVersion);
            this.pTitle.Controls.Add(this.BtnClose);
            this.pTitle.Controls.Add(this.label3);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(1350, 69);
            this.pTitle.TabIndex = 3;
            this.pTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseDown);
            this.pTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseMove);
            // 
            // lbllEVEL
            // 
            this.lbllEVEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbllEVEL.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbllEVEL.Location = new System.Drawing.Point(1049, 38);
            this.lbllEVEL.Name = "lbllEVEL";
            this.lbllEVEL.Size = new System.Drawing.Size(100, 15);
            this.lbllEVEL.TabIndex = 7;
            this.lbllEVEL.Text = "administrador";
            this.lbllEVEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(984, 17);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(165, 21);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuário";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCfg
            // 
            this.btnCfg.FlatAppearance.BorderSize = 0;
            this.btnCfg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCfg.Image = ((System.Drawing.Image)(resources.GetObject("btnCfg.Image")));
            this.btnCfg.Location = new System.Drawing.Point(1200, 13);
            this.btnCfg.Name = "btnCfg";
            this.btnCfg.Size = new System.Drawing.Size(48, 48);
            this.btnCfg.TabIndex = 5;
            this.btnCfg.UseVisualStyleBackColor = true;
            // 
            // btnLogoff
            // 
            this.btnLogoff.FlatAppearance.BorderSize = 0;
            this.btnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoff.Image = ((System.Drawing.Image)(resources.GetObject("btnLogoff.Image")));
            this.btnLogoff.Location = new System.Drawing.Point(1147, 13);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(48, 48);
            this.btnLogoff.TabIndex = 4;
            this.btnLogoff.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Location = new System.Drawing.Point(1274, -11);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 41);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "_";
            this.btnMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVersion.Location = new System.Drawing.Point(311, 32);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(52, 21);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "ver 1.0";
            this.lblVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVersion_MouseDown);
            this.lblVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblVersion_MouseMove);
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.pOptions.Controls.Add(this.btnSales);
            this.pOptions.Controls.Add(this.btnStock);
            this.pOptions.Controls.Add(this.btnRegister);
            this.pOptions.Controls.Add(this.btnHome);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptions.Location = new System.Drawing.Point(0, 69);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(200, 660);
            this.pOptions.TabIndex = 4;
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 319);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(200, 57);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Fazer Venda";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = false;
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(0, 234);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(200, 57);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Estoque";
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.Location = new System.Drawing.Point(0, 150);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 57);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SisLoja.Properties.Resources.Casa_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 63);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 57);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Início";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pDashArea
            // 
            this.pDashArea.BackColor = System.Drawing.Color.White;
            this.pDashArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDashArea.Location = new System.Drawing.Point(200, 69);
            this.pDashArea.Name = "pDashArea";
            this.pDashArea.Size = new System.Drawing.Size(1150, 660);
            this.pDashArea.TabIndex = 5;
            // 
            // fPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pDashArea);
            this.Controls.Add(this.pOptions);
            this.Controls.Add(this.pTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblUser;
        private Label lbllEVEL;
        private Label label3;
        private Label BtnClose;
        private Panel pTitle;
        private Panel pOptions;
        private Button btnHome;
        private Button btnSales;
        private Button btnStock;
        private Button btnRegister;
        private Label lblVersion;
        private Label btnMinimize;
        private Button btnLogoff;
        private Button btnCfg;
        public Panel pDashArea;
    }
}