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
using System.Threading.Tasks;
using System.Threading;


namespace UDP_Receiver
{
    public partial class Form1 : Form
    {

        private const int MyPort = 4345;
        private UdpClient Client;

        public Form1()
        {
            InitializeComponent();

            // Create the UdpClient and start listening.
            Client = new UdpClient(MyPort);
            Client.BeginReceive(DataReceived, null);
        }

        private void DataReceived(IAsyncResult ar)
        {
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, MyPort);
            byte[] data;
            try
            {
                data = Client.EndReceive(ar, ref ip);

                if (data.Length == 0)
                    return; // No more to receive
                Client.BeginReceive(DataReceived, null);
            }
            catch (ObjectDisposedException)
            {
                return; // Connection closed
            }

            // Send the data to the UI thread
            this.BeginInvoke((Action<IPEndPoint, string>)DataReceivedUI, ip, Encoding.UTF8.GetString(data));
        }

        private void DataReceivedUI(IPEndPoint endPoint, string data)
        {
            string text = data.Substring(0, 1);
            if (text == "^")  // popup message incoming
            {
                string popup = data.Substring(1, data.Length - 1);
                MessageBox.Show(popup, "Shhh...", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                switch (data)
                {
                    case "/clear":
                        tbData.Clear();
                        break;
                    case "/exit":
                        Application.Exit();
                        break;
                    default:
                        tbData.AppendText(data + Environment.NewLine);
                        break;
                }
            }           
        }
    }
}
