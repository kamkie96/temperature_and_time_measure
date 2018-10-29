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
        static SerialPort serialPort = new SerialPort();

        string dataIn;
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

        private void btnDataClick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(Data_Received);
            }
        }

        private void Data_Received(object sender, SerialDataReceivedEventArgs e)
        {
                dataIn = serialPort.ReadExisting();
                this.Invoke(new EventHandler(SetText));
        }
        private void SetText(object sender, EventArgs e)
        {
            rtbIncomingData.AppendText(dataIn);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = Convert.ToString(cbPorts.Text);
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
                serialPort.DataBits = Convert.ToInt16(cbDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopBits.Text);
  
                cbPorts.Enabled = false;
                cbParity.Enabled = false;
                cbStopBits.Enabled = false;
                cbDataBits.Enabled = false;
                cbBaudRate.Enabled = false;

                serialPort.ReadTimeout = 500;
                serialPort.WriteTimeout = 500;
                serialPort.Open();
                progressBar.Value = 100;
                rtbIncomingData.ReadOnly = false;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort.IsOpen)
            {
                serialPort.Close();
                progressBar.Value = 0;
                rtbIncomingData.ReadOnly = true;
            }
            rtbIncomingData.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            rtbIncomingData.Enabled = true;
        }

        private void rtbIncomingData_TextChanged(object sender, EventArgs e)
        {
            rtbIncomingData.SelectionStart = rtbIncomingData.Text.Length;
            rtbIncomingData.ScrollToCaret();
        }
    }
}
