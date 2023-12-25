using SisLoja.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisLoja
{
    unsafe public partial class FrmPagamento : Form
    {
        public static int waitResp;
        public static byte[] amount = new byte[12];
        public decimal valortotal;
        public int tipopagamento;
        public static int confirmapagamento;
        public bool estorno = false;
        public string codestorno;

        [DllImport("libtefseguro.dll", CallingConvention = CallingConvention.Cdecl)]        
        unsafe static extern int TEFSEG_PaymentCredit(byte[] amount);

        [DllImport("libtefseguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int TEFSEG_PaymentDebit(byte[] amount);

        [DllImport("libtefseguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int TEFSEG_PaymentTransaction(byte[] comport,int transtype,byte[] amount,        
            byte[] totalamount, int parctype, int installments);




        [StructLayout(LayoutKind.Sequential)]
        public struct result
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65542 + 1)]
            public string rawBuffer;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1023 + 1)]
            public string message;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32 + 1)]
            public string transactionCode;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10 + 1)]
            public string date;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8 + 1)]
            public string time;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12 + 1)]
            public string hostNsu;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30 + 1)]
            public string cardBrand;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6 + 1)]
            public string bin;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4 + 1)]
            public string holder;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10 + 1)]
            public string userReference;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 65 + 1 )]
            public string terminalSerialNumber;
        }

        [DllImport("PPPagSeguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int InitBTConnection(byte[] comport);
        [DllImport("PPPagSeguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int SetVersionName(
                 byte[] appName,
                 byte[] version
        );
        [DllImport("PPPagSeguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int CancelTransaction(
               IntPtr transactionResult
       );
        [DllImport("PPPagSeguro.dll", CallingConvention = CallingConvention.Cdecl)]
        unsafe static extern int SimplePaymentTransaction(
            int paymentMethod, // PPPAGSEGURO_CREDIT = 1,    PPPAGSEGURO_DEBIT = 2,    PPPAGSEGURO_VOUCHER = 3
            int installmenttype, // PPPAGSEGURO_A_VISTA = 1,    PPPAGSEGURO_PARC_VENDEDOR = 2
            int installments, // A Vista = 1  |  Número de parcelas
            byte[] amount,  // Valor
            byte[] userreference,  // Código da Venda
            IntPtr transactionResult
        );



        public FrmPagamento()
        {
            InitializeComponent();
        }
        private string GetPortFromFile()
        {
            return System.IO.File.ReadAllText("PORTA_COM_BT.txt");
        }
        private void FrmPagamento_Activated(object sender, EventArgs e)
        {
            try
            {
                unsafe
                {
                    fixed (byte* p = amount)
                    {
                        //convertToByte(p, FrmCompras.vlTotal);
                        //convertToByte(p, Convert.ToInt32(fVendas.valortotal.ToString().Replace(",","")));
                        convertToByte(p, Convert.ToInt32(valortotal.ToString().Replace(",", "")));
                    }
                }

                //circularProgressBar1.Style = ProgressBarStyle.Marquee;
                Application.DoEvents();

                int resp = 0;

                //if (FrmCompras.vlTotal != 0)
                //if (fVendas.valortotal != 0)
                if (valortotal != 0)
                {
                    result trsResult = new result();
                    byte[] comport = Encoding.ASCII.GetBytes(GetPortFromFile());
                    //byte[] codvenda = Encoding.ASCII.GetBytes("Cafe");
                    byte[] codvenda;
                    if (estorno == false)
                    {
                        codvenda = Encoding.ASCII.GetBytes(fVendas.dadosvenda.Id.ToString());
                    }
                    else
                    {
                        codvenda = Encoding.ASCII.GetBytes(codestorno);
                        estorno = false;
                    }

                    int size = Marshal.SizeOf(trsResult);
                    IntPtr ptr = Marshal.AllocHGlobal(size);
                    Marshal.StructureToPtr(trsResult, ptr, false);

                    byte[] appName = Encoding.ASCII.GetBytes("SisLoja");
                    byte[] version = Encoding.ASCII.GetBytes("0.0.1");
                    SetVersionName(appName, version);

                    //switch (FrmCompras.tipoPagamento)
                    //switch (fVendas.dadosvenda.TipoPagamento)
                    switch (tipopagamento)

                    {
                        case 0:
                            try
                            {
                                resp = InitBTConnection(comport);

                                resp = CancelTransaction(
                                            ptr
                                        );

                            }
                            catch { }

                            break;

                        //case 1:                        
                        //case 2:
                        case 3:
                            try
                            {
                                resp=InitBTConnection(comport);

                                resp = SimplePaymentTransaction(
                                            1,
                                            1,
                                            1,
                                            amount,
                                            codvenda,
                                            ptr
                                        );

                            }
                            catch { }

                            break;
                        case 4:
                            try
                            {
                                resp = InitBTConnection(comport);

                                resp = SimplePaymentTransaction(
                                            1,
                                            2,
                                            fVendas.numparcelas,
                                            amount,
                                            codvenda,
                                            ptr
                                        );

                            }
                            catch { }

                            break;
                        case 5:
                            InitBTConnection(comport);
                            resp = SimplePaymentTransaction(
                                        2,
                                        1,
                                        1,
                                        amount,
                                        codvenda,
                                        ptr
                                    );
                            break;
                    }

                    trsResult= (result)Marshal.PtrToStructure(ptr, typeof(result));
                    Marshal.FreeHGlobal(ptr);

                    //FrmCompras.ConfirmaPagamento = resp;
                    //fVendas.ConfirmaPagamento = resp;
                    confirmapagamento = resp;
                }
                else
                {
                    //FrmCompras.ConfirmaPagamento = 1;
                    //fVendas.ConfirmaPagamento = 1;
                    confirmapagamento = 1;
                }

                //circularProgressBar1.Style = ProgressBarStyle.Blocks;
                Application.DoEvents();
                //circularProgressBar1.Dispose();
                //while (circularProgressBar1.IsDisposed == false) { Application.DoEvents(); }
                this.DialogResult = DialogResult.OK;
            }
            catch {  }

        }

        private void convertToByte(byte* buff,int vl)
        {
            string str = String.Format("{0:000000000000}", vl);
            for(int i=0;i<12;i++)
            
                unsafe
                {
                    buff[i] = (byte)Convert.ToInt16(str[i]);
                }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int resp = 0;
            timer1.Enabled = false;

            //if (FrmCompras.vlTotal != 0)
            //if (fVendas.valortotal != 0)
            if (valortotal != 0)
            {
                //switch (FrmCompras.tipoPagamento)
                //switch (fVendas.dadosvenda.TipoPagamento)
                switch (tipopagamento)
                {
                    case 3: resp = TEFSEG_PaymentCredit(amount); break;
                    case 4: resp = TEFSEG_PaymentDebit(amount); break;
                }

                //FrmCompras.ConfirmaPagamento = resp;
                // fVendas.ConfirmaPagamento = resp;
                confirmapagamento = resp;
            }
            else
            {
                //FrmCompras.ConfirmaPagamento = 1;
                //fVendas.ConfirmaPagamento = 1;
                confirmapagamento = 1;
            }
            
            timer1.Interval = 1000;
        }
    }
}
