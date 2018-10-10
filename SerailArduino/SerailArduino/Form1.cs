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

namespace SerailArduino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(ports);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ports);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen == true)
            {
                return;
            }
            else
            {
                serialPort1.Open();
                button2.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                return;
            }
            else
            {
                serialPort1.Close();
                button2.Enabled = true;
                button3.Enabled = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
