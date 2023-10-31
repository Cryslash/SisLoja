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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pDashArea = new System.Windows.Forms.Panel();
            this.pTitle.SuspendLayout();
            this.pOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sistema de Frente de Loja";
            // 
            // BtnClose
            // 
            this.BtnClose.AutoSize = true;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnClose.Location = new System.Drawing.Point(1300, 18);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(28, 32);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.BtnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // pTitle
            // 
            this.pTitle.Controls.Add(this.BtnClose);
            this.pTitle.Controls.Add(this.label3);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(1350, 75);
            this.pTitle.TabIndex = 3;
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.Color.Purple;
            this.pOptions.Controls.Add(this.btnHome);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptions.Location = new System.Drawing.Point(0, 75);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(200, 654);
            this.pOptions.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Purple;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SisLoja.Properties.Resources.Casa_32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 19);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 57);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Início";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pDashArea
            // 
            this.pDashArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDashArea.Location = new System.Drawing.Point(200, 75);
            this.pDashArea.Name = "pDashArea";
            this.pDashArea.Size = new System.Drawing.Size(1150, 654);
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
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label BtnClose;
        private Panel pTitle;
        private Panel pOptions;
        private Panel pDashArea;
        private Button btnHome;
    }
}