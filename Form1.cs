using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DAV_Suit
{
    public partial class Form1 : Form
    {
        public static Form1 Instance {  get; private set; }
        private static string deviceController = "";
        private bool getversion = false;
        private bool readSerial = false;

        StringBuilder rxCMD = new StringBuilder();


        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string[] ports = SerialPort.GetPortNames();
            boxComPort.Items.AddRange(ports);
            boxBaudrate.Text = "19200";
            Serial.serialport.DataReceived += readSerialData;
            Disconnected();
        }

        private void SerialPrint(string data)
        {
            if (Globals.preFix) Serial.Println(Globals.CTRLA + data);
            else Serial.Println(data);
            sendData.Text = data;
            Thread.Sleep(50);
        }

        private void readSerialData(object sender, SerialDataReceivedEventArgs e)
        {          
            string rxData = Serial.serialport.ReadLine();
            receivedData.Text = rxData;

        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            boxComPort.Items.Clear();
            boxComPort.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string port = boxComPort.Text;
            string baudrate = boxBaudrate.Text;
            if(port != "")
            {
                if (!Serial.connected)
                {
                    if (Serial.Connect(port, baudrate))
                    {
                        btnConnect.Text = "DISCONNECT";
                        btnConnect.BackColor = Color.MediumSeaGreen;
                        Connected();
                    }
                }
                else
                {
                    if (Serial.Disconnect()) {
                        btnConnect.Text = "CONNECT";
                        btnConnect.BackColor = Color.IndianRed;
                    } 
                    Disconnected();
                }
            }
        }
        private void Connected()
        {

            boxComPort.Enabled = false;
            boxBaudrate.Enabled = false;
            btnRefresh.Enabled = false;  

        }
        private void Disconnected()
        {
            boxComPort.Enabled = true;
            boxBaudrate.Enabled = true;
            btnRefresh.Enabled = true;

        }

        private void btnCheckCom_Click(object sender, EventArgs e)
        {
            try
            {
                if(Serial.isOpen())
                {
                    MessageBox.Show("Communication OK\nConnected to " + boxComPort.Text,"Serial Status");
                }
                else
                {
                    MessageBox.Show("No Connection!", "Serial Status");
                    Disconnected();
                }
            }
            catch(Exception err) {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.softName + Globals.softVersion + Globals.softDes + Globals.comDes, "About Us", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}
