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
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace TestUART
{
    public partial class Form1 : Form
    {
        string dataTransmit;
        string dataRecived;

        int cascadeRegulator = 0;

        double time = 0.0;
        double timeMax = 8.0;
        double data;
        double dataI;
        double dataU;
        double dataW;

        string folder = @"C:\Temp\";
        string fileNameI = "pomiarI.csv";
        string fileNameW = "pomiarW.csv";
        string fileNameU = "pomiarU.csv";
        string fullPathI;
        string fullPathW;
        string fullPathU;
        CultureInfo culture;


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
            fullPathU = folder + fileNameU;
            fullPathI = folder + fileNameI;
            fullPathW = folder + fileNameW;
            System.IO.File.WriteAllText(fullPathU, string.Empty);
            System.IO.File.WriteAllText(fullPathI, string.Empty);
            System.IO.File.WriteAllText(fullPathW, string.Empty);
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
        private void button1_Click(object sender, EventArgs e)
        {
            tBoxTransmit.Text = "";
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
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
            else if (tab[0] == "data")
            {
                textBox9.Text = tab[1];
                textBox10.Text = tab[2];
                textBox11.Text = tab[3];

                fullPathU = folder + fileNameU;
                fullPathI = folder + fileNameI;
                fullPathW = folder + fileNameW;
                using (StreamWriter sw = File.AppendText(fullPathI))
                {
                    sw.WriteLine(time.ToString("0.00") + " " + textBox9.Text);
                }
                using (StreamWriter sw = File.AppendText(fullPathW))
                {
                    sw.WriteLine(time.ToString("0.00") + " " + textBox10.Text);
                }
                using (StreamWriter sw = File.AppendText(fullPathU))
                {
                    sw.WriteLine(time.ToString("0.00") + " " + textBox11.Text);
                }

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";
                chart2.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";
                chart3.ChartAreas[0].AxisX.LabelStyle.Format = "0.0";

                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.0";
                chart2.ChartAreas[0].AxisY.LabelStyle.Format = "0.0";
                chart3.ChartAreas[0].AxisY.LabelStyle.Format = "0.0";

                dataI = double.Parse(tab[1]);
                dataW = double.Parse(tab[2]);
                dataU = double.Parse(tab[3]);

                chart1.Series[0].Points.AddXY(time, dataI);
                chart2.Series[0].Points.AddXY(time, dataW);
                chart3.Series[0].Points.AddXY(time, dataU);

                chart1.ChartAreas[0].AxisX.Title = "t";
                chart2.ChartAreas[0].AxisX.Title = "t";
                chart3.ChartAreas[0].AxisX.Title = "t";

                chart1.ChartAreas[0].AxisY.Title = "i(t)";
                chart2.ChartAreas[0].AxisY.Title = "w(t)";
                chart1.ChartAreas[0].AxisY.Title = "u(t)";

                if (time > timeMax)
                {
                    chart1.Series[0].Points.RemoveAt(0);
                    chart1.ChartAreas[0].AxisX.Minimum = time - timeMax;
                    chart1.ChartAreas[0].AxisX.Maximum = time;
                    chart2.Series[0].Points.RemoveAt(0);
                    chart2.ChartAreas[0].AxisX.Minimum = time - timeMax;
                    chart2.ChartAreas[0].AxisX.Maximum = time;
                    chart3.Series[0].Points.RemoveAt(0);
                    chart3.ChartAreas[0].AxisX.Minimum = time - timeMax;
                    chart3.ChartAreas[0].AxisX.Maximum = time;
                }
                chart1.ChartAreas[0].AxisY.Maximum = dataI + dataI * 0.6;
                chart2.ChartAreas[0].AxisY.Maximum = dataW + dataW * 0.6;
                chart3.ChartAreas[0].AxisY.Maximum = dataU + dataU * 0.6;

                time = time + 0.01;
            }
        }

        private void btnClearRecive_Click(object sender, EventArgs e)
        {
            
            tBoxRecive.Text = "";
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataTransmit = "DON00000";
                serialPort1.Write(dataTransmit);
            }
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataTransmit = "DOF00000";
                serialPort1.Write(dataTransmit);
            }
        }

        private void btnKaskada_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataTransmit = "KSK00000";
                serialPort1.Write(dataTransmit);
            }
        }

        private void btnPrad_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataTransmit = "III00000";
                serialPort1.Write(dataTransmit);
            }
        }
    }
}
