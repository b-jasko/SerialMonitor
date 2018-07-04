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

namespace SerialMonitor
{
    public partial class Form1 : Form
    {
        SerialPort port;
        delegate void Delegate1();
        Delegate1 my_del1;  

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            port.ReadTimeout = 500;
            port.WriteTimeout = 500;

            Opcje.Enter += new EventHandler(Opcje_Enter);
            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            my_del1 = new Delegate1(ReadReceived);
        }

        private void ReadReceived()
        {
            AddColored(richTextBox1, port.ReadByte().ToString("X") + " ", System.Drawing.Color.Blue);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            richTextBox1.Invoke(my_del1);
        }

        void Opcje_Enter(object sender, EventArgs e)
        {
            this.cbName.Items.Clear();
            this.cbParityBits.Items.Clear();
            this.cbStopBits.Items.Clear();
            foreach (String s in SerialPort.GetPortNames()) this.cbName.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(Parity))) this.cbParityBits.Items.Add(s);
            foreach (String s in Enum.GetNames(typeof(StopBits))) this.cbStopBits.Items.Add(s);

            cbName.Text = port.PortName.ToString();
            cbBaud.Text = port.BaudRate.ToString();
            cbDataBits.Text = port.DataBits.ToString();
            cbParityBits.Text = port.Parity.ToString();
            cbStopBits.Text = port.StopBits.ToString();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.cbName.Text = "COM3";
            this.cbBaud.Text = "9600";
            this.cbDataBits.Text = "8";
            this.cbParityBits.Text = "None";
            this.cbStopBits.Text = "One";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbName.Text = port.PortName.ToString();
            cbBaud.Text = port.BaudRate.ToString();
            cbDataBits.Text = port.DataBits.ToString();
            cbParityBits.Text = port.Parity.ToString();
            cbStopBits.Text = port.StopBits.ToString();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                pictureBox.BackColor = System.Drawing.Color.Red;
                port.Close();
                labelConnection.Text = "Brak połączenia (można zmienić opcje połączenia)";
                AddColored(richTextBox1, "\nZakończono połączenie z " + port.PortName + "\n", System.Drawing.Color.Orange);
            }
            else
            {
                try
                {
                    port.PortName = this.cbName.Text;
                    port.BaudRate = Int32.Parse(this.cbBaud.Text);
                    port.DataBits = Int32.Parse(this.cbDataBits.Text);
                    port.Parity = (Parity)Enum.Parse(typeof(Parity), this.cbParityBits.Text);
                    port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.cbStopBits.Text);

                    port.Open();

                    pictureBox.BackColor = System.Drawing.Color.Green;
                    labelConnection.Text = "Aktywne połączenie (" +
                        "port:" + port.PortName.ToString() + ", " +
                        "prędkość: " + port.BaudRate.ToString() + ",\n" +
                        "bity danych: " + port.DataBits.ToString() + ", " +
                        "bity stopu: " + port.StopBits.ToString() + ", " +
                        "parzystość: " + port.Parity.ToString() + ")";
                    AddColored(richTextBox1, "Połączono z " + port.PortName + "\n" , System.Drawing.Color.Orange);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd połączenia:\n" + exc.Message);
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                AddColored(richTextBox1, ((Int32)nudMessage.Value).ToString("X") + "\n", System.Drawing.Color.Black);
                Byte[] tosend = { (Byte)nudMessage.Value };
                port.Write(tosend, 0, 1);
            }
            else MessageBox.Show("Aby wysłać bajt musisz ustanowić połączenie");
        }

        private void AddColored(System.Windows.Forms.RichTextBox richTextBox, string text, System.Drawing.Color color)
        {
            var StartIndex = richTextBox.TextLength;
            richTextBox.AppendText(text);
            var EndIndex = richTextBox.TextLength;
            richTextBox.Select(StartIndex, EndIndex - StartIndex);
            richTextBox.SelectionColor = color;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }
    }
}
