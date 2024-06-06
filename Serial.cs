using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAV_Suit
{
    public class Serial
    {
        public static SerialPort serialport = new SerialPort();
        public static bool connected;
        public static bool Connect(string port, string baudrate)
        {
            if (connected == false)
            {
                try
                {
                    serialport.PortName = port;
                    serialport.BaudRate = Convert.ToInt32(baudrate);
                    serialport.DataBits = 8;
                    serialport.StopBits = StopBits.One;
                    serialport.Parity = Parity.None;
                    serialport.DiscardNull = true;
                    serialport.Open();
                    serialport.DiscardInBuffer();
                    connected = true;
                    return true;
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

        public static bool Disconnect()
        {
            if (connected)
            {
                try
                {
                    serialport.Close();
                    connected = false;
                    return true;
                }
                catch
                {

                }
            }
            return false;
        }

        public static void Print(string cmd)
        {
            serialport.Write(cmd);
        }
        
        public static void Println(string cmd)
        {
            serialport.WriteLine(cmd + "\r");
        }
        public static bool isOpen()
        {
            return serialport.IsOpen;
        }
        public static bool isReceived()
        {
            bool isReceived = false;
            if (serialport.BytesToRead > 0) isReceived = true;
            return isReceived;
        }
    }
}
