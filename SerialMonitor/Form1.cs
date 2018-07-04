﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            port = new SerialPort();
            port.ReadTimeout = 500;
            port.WriteTimeout = 500;
            Opcje.Enter += new EventHandler(Opcje_Enter);
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
            if(port.IsOpen)
            {
                pictureBox.BackColor = System.Drawing.Color.Red;
                port.Close();
                labelConnection.Text = "Brak połączenia (można zmienić opcje połączenia)";
                //TODO: colored message
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
                    //TODO: colored message
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Błąd połączenia:\n" + exc.Message);
                }
            }
        }
    }
}
