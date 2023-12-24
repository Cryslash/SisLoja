namespace SisLoja
{
    partial class FrmPagamento
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lblData = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = null;
            circularProgressBar1.AnimationSpeed = 1000;
            circularProgressBar1.BackColor = Color.White;
            circularProgressBar1.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point);
            circularProgressBar1.ForeColor = Color.Silver;
            circularProgressBar1.InnerColor = Color.White;
            circularProgressBar1.InnerMargin = 1;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(318, 248);
            circularProgressBar1.Margin = new Padding(4, 3, 4, 3);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Silver;
            circularProgressBar1.OuterMargin = -3;
            circularProgressBar1.OuterWidth = 3;
            circularProgressBar1.ProgressColor = Color.FromArgb(0, 192, 0);
            circularProgressBar1.ProgressWidth = 3;
            circularProgressBar1.SecondaryFont = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point);
            circularProgressBar1.Size = new Size(175, 93);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.FromArgb(166, 166, 166);
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "";
            circularProgressBar1.TabIndex = 0;
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 70;
            circularProgressBar1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 60);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.ForeColor = Color.FromArgb(64, 70, 77);
            lblData.Location = new Point(284, 157);
            lblData.Name = "lblData";
            lblData.Size = new Size(249, 50);
            lblData.TabIndex = 32;
            lblData.Text = "Aguardando a transação ser\r\ncompletada...";
            // 
            // FrmPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(629, 403);
            Controls.Add(lblData);
            Controls.Add(pictureBox1);
            Controls.Add(circularProgressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPagamento";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmPagamento";
            Activated += FrmPagamento_Activated;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label lblData;
    }
}