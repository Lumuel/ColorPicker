using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace ColorPicker
{
    public partial class frmFarbauswahl : Form
    {
        string rValue = String.Empty;
        string gValue = String.Empty;
        string bValue = String.Empty;

<<<<<<< HEAD
        string blep = "c";

        byte[] asciiRvalue;
        byte[] asciiGvalue;
        byte[] asciiBvalue;


        bool noNewSelection = false;
=======
        char[] cRvalue = new char[4];
        char[] cGvalue = new char[4];
        char[] cBvalue = new char[4];
>>>>>>> origin/master

        public frmFarbauswahl()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void frmFarbauswahl_btnStart_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            noNewSelection = false;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rValue = "R" + colorDigits(colorDialog.Color.R); //R255
                gValue = "G" + colorDigits(colorDialog.Color.G); //G255
                bValue = "B" + colorDigits(colorDialog.Color.B); //B255

                asciiRvalue = Encoding.UTF8.GetBytes(rValue);
                asciiGvalue = Encoding.UTF8.GetBytes(gValue);
                asciiBvalue = Encoding.UTF8.GetBytes(bValue);

                noNewSelection = true;
            }

            send();
        }
        public void send()
        {
            string[] ports = SerialPort.GetPortNames();

            for (int i = 0; i < ports.Length; i++)
            {
                if (!ports[i].Equals("COM3"))
                {
                    SerialPort colorOut = new SerialPort(ports[i], 9600, Parity.None, 8, StopBits.One);
                    colorOut.Encoding = System.Text.Encoding.ASCII;
                    colorOut.Open();
                    colorOut.Write(rValue);
                    colorOut.Write(gValue);
                    colorOut.Write(bValue);
                    colorOut.Close();
                }
            }

            //for(int j = 0; j <= 5; j++)
            //{
            //    {
            //for (int i = 0; i < ports.Length; i++)
            //{
            //    SerialPort colorOut = new SerialPort(ports[i], 9600, Parity.None, 8, StopBits.One);
            //    colorOut.Encoding = System.Text.Encoding.UTF8;
            //    colorOut.Open();

            //    colorOut.Write(asciiRvalue, 0, asciiRvalue.Length);
            //    Thread.Sleep(1000);

            //    colorOut.Write(asciiGvalue, 0, asciiGvalue.Length);
            //    Thread.Sleep(1000);
            //    colorOut.Write(asciiBvalue, 0, asciiBvalue.Length);
            //    Thread.Sleep(1000);
            //    colorOut.Close();
            //}
            //    }
            //}            
=======
            if(frmFarbauswahl_cbPort.SelectedItem != null)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    rValue = "R" + colorDigits(colorDialog.Color.R); //R255
                    gValue = "G" + colorDigits(colorDialog.Color.G); //G255
                    bValue = "B" + colorDigits(colorDialog.Color.B); //B255

                    cRvalue = rValue.ToCharArray();
                    cGvalue = gValue.ToCharArray();
                    cBvalue = bValue.ToCharArray();
                }
                send();
            }
            else
            {
                MessageBox.Show("Please select a port.", "Error");
            }
        }

        public void InitializeComboBox()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string element in ports)
            {
                frmFarbauswahl_cbPort.Items.Add(element);
            }
        }

        public void send()
        {
            try
            {
                string port = frmFarbauswahl_cbPort.SelectedItem.ToString();
                sendDaChars(cRvalue, port);
                sendDaChars(cGvalue, port);
                sendDaChars(cBvalue, port);
            }
            catch(Exception)
            {
            }            
        }

        public void sendDaChars(char[] charArray, string port)
        {
            foreach (char element in charArray)
            {
                SerialPort colorOut = new SerialPort(port, 9600, Parity.None, 8, StopBits.One);
                colorOut.Encoding = System.Text.Encoding.ASCII;
                colorOut.Open();
                string outElement = element.ToString();
                colorOut.Write(outElement);
                Thread.Sleep(10);
                colorOut.Close();
            }
>>>>>>> origin/master
        }

        public string colorDigits(int number)
        {
            string colourStr = String.Empty;

            if (number < 10)
            {
                colourStr = "00" + number.ToString();
            }
            else if (number < 100)
            {
                colourStr = "0" + number.ToString();
            }
            else
            {
                return number.ToString();
            }

            return colourStr;
        }
    }
}