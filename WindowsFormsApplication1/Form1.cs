using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static byte[] result = new byte[1024];
        private static byte[] client_result = new byte[1024];

        private static int port = 8888;
        static Socket serverSocket;
        private static Socket clientSocket;

        delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();
        }

        //连接服务器
        private void button2_Click(object sender, EventArgs e)
        {
            IPAddress target_ip = IPAddress.Parse(remote.Text);
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                clientSocket.Connect(new IPEndPoint(target_ip, port));
                label2.Text = "连接成功";
            }
            catch (Exception ex)
            {
                label2.Text = "连接失败";
                return;
            }

            Thread response_thread = new Thread(ListenServerResponse);
            response_thread.IsBackground = true;
            response_thread.Start();
            
        }

        private void ListenServerResponse()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                Thread receive_thread = new Thread(ReceiveServerMessage);
                receive_thread.Start(clientSocket);
            }
        }

        private void ReceiveServerMessage(object clientSocket)
        {
            Socket client_socket = (Socket)clientSocket;
            while (true)
            {
                int receiveLength = client_socket.Receive(client_result);
                if (receiveLength > 0)
                {
                    this.setChatContent("收到消息：" + Encoding.ASCII.GetString(client_result, 0, receiveLength));
                }
            }
        }

        //启动监听
        private void button3_Click(object sender, EventArgs e)
        {
            IPAddress server_ip = IPAddress.Parse(local.Text);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(new IPEndPoint(server_ip, port));
            serverSocket.Listen(10);
            label1.Text = "start listen";

            Thread server_thread = new Thread(ListenClientConnect);
            server_thread.IsBackground = true;
            server_thread.Start();
        }

        private void ListenClientConnect()
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                Thread receive_thread = new Thread(ReceiveMessage);
                receive_thread.Start(clientSocket);
            }
        }

        private void ReceiveMessage(object clientSocket)
        {
            Socket client_socket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    int receiveNumber = client_socket.Receive(result);
                    this.setChatContent(client_socket.RemoteEndPoint.ToString() + ":" + Encoding.ASCII.GetString(result,0,receiveNumber));
                }
                catch (Exception ex)
                {
                    this.chatBox.AppendText(ex.Message);
                    break;
                }
            }
        }

        //发送按钮
        private void button1_Click(object sender, EventArgs e)
        {
            clientSocket.Send(Encoding.ASCII.GetBytes(richTextBox1.Text));
            this.setChatContent("我说:" + richTextBox1.Text);
            richTextBox1.Text = "";
        }

        private void setChatContent(string text)
        {
            if (this.chatBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setChatContent);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.chatBox.AppendText(text + "\r\n");
            }
        }

    }
}
