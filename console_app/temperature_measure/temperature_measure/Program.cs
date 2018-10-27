using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Threading;

namespace temperature_measure
{
    class Program
    {
        static bool _continue;
        static SerialPort serialPort;


        static void Main(string[] args)
        {
            string name;
            string message;
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            Thread readThread = new Thread(Read);

            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 115200;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;

            serialPort.ReadTimeout = 500;
            serialPort.WriteTimeout = 500;

            serialPort.Open();
            _continue = true;
            readThread.Start();

            //Console.WriteLine("Name: ");
            name = Console.ReadLine();
            
            Console.WriteLine("Press 'q' to exit");

            while (_continue)
            {
                message = Console.ReadLine();

                if (stringComparer.Equals("q", message))
                {
                    _continue = false;
                }
                else
                {
                    serialPort.WriteLine(
                        String.Format("<{0}>: {1}",name, message));
                }
            }

            readThread.Join();
            serialPort.Close();
        }

    public static void Read()
    {
        while (_continue)
        {
            try
            {
                string message = serialPort.ReadLine();
                Console.WriteLine("Thread works{0}\n",message);
            }
            catch (TimeoutException) { }
        }
    }



}
}

