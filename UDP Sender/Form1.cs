using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace UDP_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            // make sure text box contains data, or do nothing.
            if (string.IsNullOrEmpty(txtMessage.Text)) return;

            // wrap in using
            using (UdpClient udpClient = new UdpClient())
            {
                // loopback, because I'm testing. Otherwise, use .Any instead
                udpClient.Connect(IPAddress.Loopback, 4345);
                Byte[] senddata1 = Encoding.ASCII.GetBytes(txtMessage.Text);
                udpClient.Send(senddata1, senddata1.Length);
            }
            // clean up
            txtMessage.Clear();
            txtMessage.Focus();
        }
    }
}
