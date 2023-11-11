namespace SisLoja.UI
{
    partial class fTerminal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTerminal));
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.pbImgProd = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblCor = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.pNumeros = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).BeginInit();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDevice
            // 
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(830, 327);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(101, 23);
            this.cbDevice.TabIndex = 0;
            this.cbDevice.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(830, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivo";
            this.label1.Visible = false;
            // 
            // pbVideo
            // 
            this.pbVideo.Location = new System.Drawing.Point(744, 79);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(175, 211);
            this.pbVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVideo.TabIndex = 2;
            this.pbVideo.TabStop = false;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(736, 327);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(88, 23);
            this.tbResult.TabIndex = 4;
            this.tbResult.Visible = false;
            // 
            // timer
            // 
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(254, 100);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(128, 50);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(254, 170);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(157, 50);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "Modelo";
            // 
            // pbImgProd
            // 
            this.pbImgProd.Image = ((System.Drawing.Image)(resources.GetObject("pbImgProd.Image")));
            this.pbImgProd.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbImgProd.InitialImage")));
            this.pbImgProd.Location = new System.Drawing.Point(12, 79);
            this.pbImgProd.Name = "pbImgProd";
            this.pbImgProd.Size = new System.Drawing.Size(224, 224);
            this.pbImgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgProd.TabIndex = 9;
            this.pbImgProd.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(904, 55);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Aponte o QrCode e veja as opções disponíveis\r\n";
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(931, 70);
            this.pTitle.TabIndex = 9;
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCor.ForeColor = System.Drawing.Color.White;
            this.lblCor.Location = new System.Drawing.Point(12, 318);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(504, 32);
            this.lblCor.TabIndex = 10;
            this.lblCor.Text = "Disponíveis nas seguintes cores e números";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPreco.ForeColor = System.Drawing.Color.White;
            this.lblPreco.Location = new System.Drawing.Point(254, 240);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(121, 50);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço";
            // 
            // pNumeros
            // 
            this.pNumeros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pNumeros.Location = new System.Drawing.Point(0, 358);
            this.pNumeros.Name = "pNumeros";
            this.pNumeros.Size = new System.Drawing.Size(931, 231);
            this.pNumeros.TabIndex = 12;
            // 
            // fTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(931, 589);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.pNumeros);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pbImgProd);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevice);
            this.Name = "fTerminal";
            this.Text = "fTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTerminal_FormClosing);
            this.Load += new System.EventHandler(this.fTerminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).EndInit();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbDevice;
        private Label label1;
        private PictureBox pbVideo;
        private TextBox tbResult;
        private System.Windows.Forms.Timer timer;
        private Label lblNome;
        private Label lblModelo;
        private PictureBox pbImgProd;
        private Label lblTitle;
        private Panel pTitle;
        private Label lblCor;
        private Label label4;
        private Label label7;
        private Label lblPreco;
        private Panel pNumeros;
    }
}