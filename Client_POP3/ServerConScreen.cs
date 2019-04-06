using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Client_POP3
{
    public partial class ServerConScreen : Form
    {
        
        public ServerConScreen()
        {

            Client.ClientIni();
            InitializeComponent();
            Client.StartClient();
            //SocketThread = new Thread(()=>Client.StartClient("127.0.0.1", "ta"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.IPTextBox.Text, @"[A-Za-z0-9\-]+\p{P}[A-Za-z0-9\-]+\p{P}[A-Za-z0-9\-]+"))
            {
                Client.log.LOGBox.AppendText("C: +OK recognised regex \r\n");
                string ans = Client.client.connectToServer(this.IPTextBox.Text);
                if(ans == "S: +OK")
                {
                    Client.log.LOGBox.AppendText("S: " + ans + " server connsected\r\n", Color.ForestGreen);
                    Client.showLoginScreen(this , this.IPTextBox.Text);
                    this.Hide();
                }
                else
                {
                    Client.log.LOGBox.AppendText("S: " + ans+ "\r\n",Color.Red);
                }
                
                //Client.client = new newClient(this.IPTextBox.Text);
            }
            else
            {
                Client.log.LOGBox.AppendText("C: -ERR incorrect format server name\r\n");
            }

            //Client.log.LOGBox
                //Client.printMessageLog("S: -ERR incorect IP Address (Maybe you mean \"127.0.0.1\")\r\n");
           
        }

        
    }
}
