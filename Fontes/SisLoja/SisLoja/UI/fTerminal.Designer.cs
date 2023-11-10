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
            this.cbDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbVideo = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbImgProd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDevice
            // 
            this.cbDevice.FormattingEnabled = true;
            this.cbDevice.Location = new System.Drawing.Point(818, 554);
            this.cbDevice.Name = "cbDevice";
            this.cbDevice.Size = new System.Drawing.Size(101, 23);
            this.cbDevice.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dispositivo";
            // 
            // pbVideo
            // 
            this.pbVideo.Location = new System.Drawing.Point(727, 348);
            this.pbVideo.Name = "pbVideo";
            this.pbVideo.Size = new System.Drawing.Size(192, 185);
            this.pbVideo.TabIndex = 2;
            this.pbVideo.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(727, 554);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Começar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(793, 554);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(22, 23);
            this.tbResult.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(46, 103);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(116, 50);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "nome";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModelo.Location = new System.Drawing.Point(46, 166);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(148, 50);
            this.lblModelo.TabIndex = 6;
            this.lblModelo.Text = "modelo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(46, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 48);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(46, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 48);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Location = new System.Drawing.Point(46, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 8;
            // 
            // pbImgProd
            // 
            this.pbImgProd.Location = new System.Drawing.Point(663, 86);
            this.pbImgProd.Name = "pbImgProd";
            this.pbImgProd.Size = new System.Drawing.Size(256, 256);
            this.pbImgProd.TabIndex = 9;
            this.pbImgProd.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(872, 59);
            this.label2.TabIndex = 10;
            this.label2.Text = "Veja Aqui as Cores e os Números Disponíveis";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(71)))), ((int)(((byte)(87)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 70);
            this.panel4.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cores e Números Disponíveis";
            // 
            // fTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(931, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pbImgProd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDevice);
            this.Name = "fTerminal";
            this.Text = "fTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTerminal_FormClosing);
            this.Load += new System.EventHandler(this.fTerminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImgProd)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbDevice;
        private Label label1;
        private PictureBox pbVideo;
        private Button btnStart;
        private TextBox tbResult;
        private System.Windows.Forms.Timer timer;
        private Label lblNome;
        private Label lblModelo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pbImgProd;
        private Label label2;
        private Panel panel4;
        private Label label3;
    }
}