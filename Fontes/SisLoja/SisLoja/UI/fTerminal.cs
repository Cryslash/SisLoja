using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void fTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
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
                }
            }
            catch (Exception ex)
            {
            }        
        }
    }
}
