using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace SisLoja.UI
{
    public partial class fTerminal : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        TerminalBLL BLL = new TerminalBLL();
        string qrcode = string.Empty;

        public fTerminal()
        {
            InitializeComponent();
        }

        private void fTerminal_Load(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice();
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in CaptureDevice)
                cbDevice.Items.Add(device.Name);
            cbDevice.SelectedIndex = 0;

            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void StopVideoCapture()
        {
            while (FinalFrame.IsRunning)
            {
                FinalFrame.SignalToStop();
                FinalFrame.WaitForStop();
            }

            FinalFrame.NewFrame -= new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.VideoSourceError -= new VideoSourceErrorEventHandler(ErrorHandler);
            FinalFrame = null;

            var bitmap = pbVideo.Image;
            pbVideo.Image = null;
            bitmap?.Dispose();
        }
        private void ErrorHandler(object sender, VideoSourceErrorEventArgs eventArgs)
        {
            Console.WriteLine("Video feed source error: " + eventArgs.Description);
        }

        private void fTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVideoCapture();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pbVideo.Image);
            try
            {               
                    string decoded = result?.ToString().Trim();
                    if (decoded != string.Empty)
                    {
                        tbResult.Text = decoded;
                        qrcode = decoded;
                    
                    Carregar_Dados_Produto(qrcode);
                    }
            }
            catch { }
        }
        private void Limpar_Dados() 
        {
            pNumeros.Controls.Clear();
        }
        private void Carregar_Dados_Produto(string qrcode)
        {
            modeloProduto produto = BLL.Verificar_Info_ProdutoDAL(qrcode);

            lblNome.Text = produto.Nome;
            lblModelo.Text = produto.Modelo;
            lblPreco.Text = string.Format("{0} R$", produto.PrecoVenda.ToString());
            pbImgProd.ImageLocation = produto.Img;

            Mostrar_Cores_E_Numeros_Disponiveis(qrcode);
        }
        private Color Ler_Cor(string cor) 
        {
            if (cor == "Branco" | cor == "Branca")
            {
                return Color.White;
            }
            if (cor == "Preto" | cor == "Preta")
            {
                return Color.Black;
            }
            if (cor == "Bege" | cor == "Nude")
            {
                return Color.Salmon;
            }
            if (cor == "Dourado" | cor == "Dourada" | cor == "Gold")
            {
                return Color.Gold;
            }
            return Color.Transparent;
        }
        private void Mostrar_Cores_E_Numeros_Disponiveis(string qrcode)
        {
            DataTable disponiveis = BLL.Verificar_Cores_E_NumerosDAL(qrcode);
            int Y = 27; //390
            int pY = 15; //378
            Limpar_Dados();
            foreach (DataRow row in disponiveis.Rows )
            {
                int number = 18;
                int X = 127;
                //Criando panel com aa cores disponiveis
                Panel p = new Panel();
                p.Name = row["Cor"].ToString();
                p.Size = new Size(48,48);
                p.BackColor = Ler_Cor(row["Cor"].ToString());
                p.Location = new System.Drawing.Point(61, pY);
                pNumeros.Controls.Add(p);
                pY = pY + 76;
                foreach (DataColumn col in disponiveis.Columns)
                {
                    if (Convert.ToInt32(row["Num" + number].ToString()) > 0)
                    {
                        //Criando um label com os números disponiveis
                        Label lbl = new Label();
                        lbl.Name = "lbl"+ number.ToString();
                        lbl.Text = number.ToString();
                        //lbl.Font = new Font("Segoe UI", 18, FontStyle.Regular);
                        //lbl.ForeColor = Color.FromArgb(51, 51, 51);
                        lbl.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                        lbl.ForeColor = Color.White;
                        lbl.Location = new System.Drawing.Point(X, Y);
                        lbl.Size = new Size(44, 32);
                        pNumeros.Controls.Add(lbl);
                        X = X + 50;
                    }
                    if (number < 44)
                number++;
                }
                Y = Y + 74;
            }
        }
    }
}
