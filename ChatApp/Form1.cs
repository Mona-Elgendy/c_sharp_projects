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

namespace ChatApp
{
    public partial class Form1 : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer; // for sending and receiving messages

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setup socket
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            // get user ip
            textLocalIp.Text = GetLocalIp();
            textRemoteIp.Text= GetLocalIp();



        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //binding socket
            epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
            sck.Bind(epLocal);

            //connect to remote ip
            epRemote = new IPEndPoint(IPAddress.Parse(textRemoteIp.Text), Convert.ToInt32(textRemotePort.Text));
            sck.Connect(epRemote);

            //listening to specific port
            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
        }

        private void MessageCallBack(IAsyncResult aResult)
        {

            try
            { 
            byte[] ReceivedData = new byte[1500];
            ReceivedData = (byte[])aResult.AsyncState;

            //converting byte[] to string
            ASCIIEncoding aEncoding = new ASCIIEncoding();
            string receiverMessage = aEncoding.GetString(ReceivedData);

            //adding this message to listbox
            listMessage.Items.Add("Friend :  " + receiverMessage);

            buffer = new byte[1500];
            sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            //convert string message to byte[]

            ASCIIEncoding aEncoding = new ASCIIEncoding();
            byte[] sendingMessage = new byte[1500];
            sendingMessage = aEncoding.GetBytes(textMessage.Text);

            //sending the encoded message
            sck.Send(sendingMessage);

            //adding to the listbox
            listMessage.Items.Add("ME :   " + textMessage.Text);
            textMessage.Text = "";



        }

        private string GetLocalIp()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    return ip.ToString();
            }
            return "127.0.0.1";
        }
    }
}
