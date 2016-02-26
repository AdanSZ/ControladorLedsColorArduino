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

namespace arduino_controller
{
    
    public partial class Form1 : Form
    {
        SerialPort currentPort;
        bool portFound;
        public Form1()
        {
            InitializeComponent();
        }
   
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void arduino_data(String dato) {
            SerialPort port = new SerialPort("COM3", 9600);
            port.Open();
            //while (true)
            //{
                //String s = Console.ReadLine();
                //if (s.Equals("exit"))
                //{
                //    break;
                //}
                port.Write(dato);
            //}
            port.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arduino_data("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arduino_data("2");
        }
    }
}
