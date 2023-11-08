namespace SisLoja.UI
{
    partial class fRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRegister));
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(129, 87);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(162, 167);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Cadastrar Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.Location = new System.Drawing.Point(364, 87);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(162, 167);
            this.btnProduto.TabIndex = 1;
            this.btnProduto.Text = "Cadastrar Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Image")));
            this.btnEntrada.Location = new System.Drawing.Point(596, 87);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(162, 167);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Cadastrar Entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.Location = new System.Drawing.Point(837, 87);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(162, 167);
            this.btnOut.TabIndex = 3;
            this.btnOut.Text = "Cadastrar Retirada";
            this.btnOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOut.UseVisualStyleBackColor = false;
            // 
            // fRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCliente;
        private Button btnProduto;
        private Button btnEntrada;
        private Button btnOut;
    }
}