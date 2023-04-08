using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Server
{
    public partial class Server : Form
    {
        private TcpListener _listener;
        private TcpClient _client;
        private NetworkStream NetworkStream;
        private Thread _thread;
        Boolean _accept = false;
        public Server()
        {
            InitializeComponent();
        }

        private void Server_Load(object sender, EventArgs e)
        {
            tb_ip.Text = tb_port.Text = "";
            btn_send.Enabled = false;
            btn_stop.Enabled = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            btn_connect.Enabled = false;
            string ip = tb_ip.Text;
            string port = tb_port.Text;
            bool checkaddr = IsIpV4Address(ip);
            bool checkport = IsPort(port);
            if (checkaddr && checkport)
            {
                btn_stop.Enabled = true;
                btn_send.Enabled = true;
                _listener = new TcpListener(IPAddress.Parse(ip), Convert.ToInt32(port));
                _listener.Start();

                _client = _listener.AcceptTcpClient();

                _thread = new Thread(acpclient);
                _thread.Start();
                _accept = true;
            }
            else
            {
                if (!checkaddr) lb_text.Items.Add("Lỗi Address");
                if (!checkport) lb_text.Items.Add("Lỗi Port");
            }
        }
        private void acpclient()
        {
            while (_accept)
            {
                if (_client.Available > 0)
                {
                    NetworkStream = _client.GetStream();

                    byte[] msg = new byte[_client.ReceiveBufferSize];
                    NetworkStream.Read(msg, 0, msg.Length);
                    string _msg = Encoding.UTF8.GetString(msg);
                    lb_text.Items.Add(_msg.ToString());
                }    
            }    
        }
        public static bool IsPort(string str)
        {
            try
            {
                if (Int32.Parse(str) >= 0)
                {
                    return true;
                }    
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public static bool IsIpV4Address(string str)
        {
            string[] arr = str.Split('.');
            if (arr.Length != 4)
                return false;
            foreach (string sub in arr)
            {
                try
                {
                    int test = int.Parse(sub);
                    if (test < 0 || test > 255)
                        return false;

                    if (test.ToString().Length != sub.Length)
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            _listener.Stop();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }
    }
}
