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
using System.Runtime.InteropServices;

namespace Client
{
    public partial class Client : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string ip = tb_ip.Text.Trim();
            string port = tb_port.Text.Trim();
            bool checkaddr = IsIpV4Address(ip);
            bool checkport = IsPort(port);
            if (checkaddr && checkport)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(ip), Convert.ToInt32(port));
                if (client.Connected)
                {
                    stream = client.GetStream();
                    byte[] msg = Encoding.ASCII.GetBytes("Client Connect");
                    stream.Write(msg, 0, msg.Length);
                    client.Close();
                }    
            }
            else
            {
                if (!checkaddr) lb_text.Items.Add("Lỗi Address");
                if (!checkport) lb_text.Items.Add("Lỗi Port");
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

        private void btn_send_Click(object sender, EventArgs e)
        {
            string ip = tb_ip.Text.Trim();
            string port = tb_port.Text.Trim();
            bool checkaddr = IsIpV4Address(ip);
            bool checkport = IsPort(port);
            if (checkaddr && checkport)
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(ip), Convert.ToInt32(port));
                if (client.Connected)
                {
                    stream = client.GetStream();
                    byte[] msg = Encoding.ASCII.GetBytes(tb_text.Text);
                    stream.Write(msg, 0, msg.Length);
                    client.Close();
                }
            }
            else
            {
                if (!checkaddr) lb_text.Items.Add("Lỗi Address");
                if (!checkport) lb_text.Items.Add("Lỗi Port");
            }
        }
    }
}
