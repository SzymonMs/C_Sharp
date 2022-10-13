using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestUART
{
    public partial class Form1 : Form
    {
        string dataTransmit;
        string dataRecived;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxPort.Items.AddRange(ports);
            statusPort.Enabled = false;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudeRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxData.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStop.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);

                serialPort1.Open();

                statusPort.Text = "ON";
                statusPort.ForeColor = Color.Green;
                statusPort.Enabled = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                statusPort.Text = "OFF";
                statusPort.ForeColor = Color.Red;

            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataTransmit = tBoxTransmit.Text;
                serialPort1.Write(dataTransmit);
            }
        }
        /// <summary>
        /// Clear of textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tBoxTransmit.Text = "";
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //if (this.InvokeRequired)
            //{
            //    this.BeginInvoke(new EventHandler<SerialDataReceivedEventArgs>(serialPort1_DataReceived), new object[] { sender, e });
            //    return;
            //}
            dataRecived = serialPort1.ReadLine();
            serialPort1.DiscardInBuffer();
            serialPort1.DiscardOutBuffer();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            tBoxRecive.Text = dataRecived;
            string[] tab;
            tab = dataRecived.Split(' ');
            if (tab[0] == "parm")
            {
                textBox1.Text = tab[1];
                textBox2.Text = tab[2];
                textBox3.Text = tab[3];
                textBox4.Text = tab[4];
                textBox5.Text = tab[5];
                textBox6.Text = tab[6];
                textBox7.Text = tab[7];
                textBox8.Text = tab[8];
            }
        }

        private void btnClearRecive_Click(object sender, EventArgs e)
        {
            tBoxRecive.Text = "";
        }
    }
}
