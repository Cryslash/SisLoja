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
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnInn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.Location = new System.Drawing.Point(129, 87);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(162, 167);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Cadastrar Cliente";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.Location = new System.Drawing.Point(364, 87);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(162, 167);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Cadastrar Produto";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnInn
            // 
            this.btnInn.BackColor = System.Drawing.SystemColors.Control;
            this.btnInn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInn.Image = ((System.Drawing.Image)(resources.GetObject("btnInn.Image")));
            this.btnInn.Location = new System.Drawing.Point(596, 87);
            this.btnInn.Name = "btnInn";
            this.btnInn.Size = new System.Drawing.Size(162, 167);
            this.btnInn.TabIndex = 2;
            this.btnInn.Text = "Cadastrar Entrada";
            this.btnInn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInn.UseVisualStyleBackColor = false;
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.Controls.Add(this.btnInn);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fRegister";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomer;
        private Button btnProduct;
        private Button btnInn;
        private Button btnOut;
    }
}