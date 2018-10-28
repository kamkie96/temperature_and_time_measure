using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Forms
{
    public partial class Form1 : Form
    {
        static bool _continue;
        static SerialPort serialPort = new SerialPort();

        string name;
        string message;
        StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;


        public Form1()
        {
            InitializeComponent();

            cbPorts.Items.Add("COM1");
            cbPorts.Items.Add("COM2");
            cbPorts.Items.Add("COM3");

            cbBaudRate.Items.Add(300);
            cbBaudRate.Items.Add(600);
            cbBaudRate.Items.Add(1200);
            cbBaudRate.Items.Add(2400);
            cbBaudRate.Items.Add(9600);
            cbBaudRate.Items.Add(14400);
            cbBaudRate.Items.Add(19200);
            cbBaudRate.Items.Add(38400);
            cbBaudRate.Items.Add(57600);
            cbBaudRate.Items.Add(115200);
            cbBaudRate.Items.ToString();

            cbParity.Items.Add("None");
            cbParity.Items.Add("Even");
            cbParity.Items.Add("Odd");

            cbStopBits.Items.Add("One");
            cbStopBits.Items.Add("Two");

            cbDataBits.Items.Add(8);
            cbDataBits.Items.Add(16);
        }

        public static void Read()
        {
            while (_continue)
            {
                try
                {
                    string message = serialPort.ReadExisting();
                }
                catch (TimeoutException) { }
            }
        }

        private void btnDataClick(object sender, EventArgs e)
        {
            Thread readThread = new Thread(Read);

            btnData.Text = "Open";
            serialPort.PortName = Convert.ToString(cbPorts.Text);
            serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
            serialPort.DataBits = Convert.ToInt16(cbDataBits.Text);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            serialPort.Open();

            _continue = true;
            readThread.Start();

            //Console.WriteLine("Name: ");
            name = serialPort.ReadExisting();

            while (_continue)
            {
                message = serialPort.ReadExisting();

                SetText(message);
            }

            readThread.Join();
            serialPort.Close();
        }

        private void SetText(string text)
        {
            this.rtbIncomingData.Text += text;
        }
    }
}
