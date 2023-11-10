namespace SisLoja.UI
{
    partial class fConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConsultar));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.White;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.Location = new System.Drawing.Point(611, 101);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(162, 167);
            this.btnEstoque.TabIndex = 5;
            this.btnEstoque.Text = "Consultar Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnProduto
            // 
            this.btnProduto.BackColor = System.Drawing.Color.White;
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
            this.btnProduto.Location = new System.Drawing.Point(379, 101);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(162, 167);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.Text = "Consultar Produto";
            this.btnProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduto.UseVisualStyleBackColor = false;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.White;
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(144, 101);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(162, 167);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Consultar Cliente";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // fConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fConsultar";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEstoque;
        private Button btnProduto;
        private Button btnCliente;
    }
}