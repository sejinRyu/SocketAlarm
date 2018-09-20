using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace SocketAlarm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            ipEndPoint = new IPEndPoint(Dns.GetHostAddresses("sejin.site")[0], 14141);

            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(ipEndPoint);

            MessageLabel.Text = "Connect Success!";
            this.BackColor = Color.Yellow;
            Application.DoEvents();

            RecvThread = new Thread(delegate ()
            {
                Byte[] buf;


                while (true)
                {
                    buf = new Byte[1024];
                    client.Receive(buf);
                    string msg = Encoding.Default.GetString(buf);
                    if (msg.Substring(0, 4).Equals("FLAG"))
                    {
                        MessageBox.Show(msg);
                    }
                    else 
                    {
                        MessageLabel.Text = msg;
                        if (msg.Substring(0, 3).Equals("Run"))
                        {
                            this.BackColor = Color.Lime;
                        }
                        else if(msg.Substring(0,4).Equals("Stop"))
                        {
                            this.BackColor = Color.Red;
                        }
                        Application.DoEvents();
                    }

                    //MessageBox.Show(

                    //new Form() {  TopMost = true },

                    //Encoding.Default.GetString(buf)

                    //);

                    //MessageLabel.Text = "";
                    //Application.DoEvents();
                    //MessageLabel.Text = Encoding.Default.GetString(buf);
                    //Application.DoEvents();
                }
            });
            RecvThread.Start();
            ConnectButton.Visible = false;
            label1.Visible = false;
            RefreshButton.Visible = true;
            label5.Visible = true;
            IsOpened = true;
            
            

        }

        private IPEndPoint ipEndPoint;
        private Socket client;
        private Thread RecvThread;
        private Boolean IsOpened = false;


        private void StartButton_Click(object sender, EventArgs e)
        {
            client.Send(Encoding.UTF8.GetBytes("Start"));
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            client.Send(Encoding.UTF8.GetBytes("Stop"));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsOpened==true)
            {
                client.Close();
                RecvThread.Abort();
            }
            
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "...";
            this.BackColor = Color.Aqua;
            Application.DoEvents();
            client.Send(Encoding.UTF8.GetBytes("RefreshRequest"));
        }
    }
}
