using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_POP3
{
    public partial class Login_Register_Screen : Form
    {
        LOGScreen log;
        ServerConScreen serverSc;
        public Login_Register_Screen(LOGScreen logScreen, ServerConScreen serverSc)
        {
            this.log = logScreen;
            this.serverSc = serverSc;
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string res = Client.USER(this.usernameBox.Text);
            if(res == null)
            {
                Client.QUIT();
                Client.client.connectToServer(Client.server);
                res = Client.USER(this.usernameBox.Text);
            }
            if (res[0]=='+' && res[1] =='O' && res[2] == 'K')
            {
                log.LOGBox.AppendText("S:" + res + "\r\n", Color.ForestGreen);
                string res1 = Client.PASS(this.passwordBox.Text);
                
                if (res1[0] == '+' && res1[1] == 'O' && res1[2] == 'K')
                {
                    log.LOGBox.AppendText("S: " + res1 + "\r\n" , Color.ForestGreen);
                    Client.ClientConnected(serverSc);
                }
                else
                {
                    log.LOGBox.AppendText(res1 + "\r\n", Color.Red);
                }
            }
            else
            {
                log.LOGBox.AppendText(res + "\r\n",Color.Red);
            }
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            /*string quit = Client.QUIT();
            log.LOGBox.AppendText(quit + "\r\n", Color.Red);*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.LOGBox.AppendText("C: QUIT \r\n", Color.DarkCyan);
            string quit = Client.QUIT();
            log.LOGBox.AppendText("S:" + quit + "\r\n", Color.Red);
            this.Hide();
            serverSc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string res = Client.APOP(this.usernameBox.Text,this.passwordBox.Text);
            if (res == null)
            {
                Client.QUIT();
                Client.client.connectToServer(Client.server);
                res = Client.APOP(this.usernameBox.Text, this.passwordBox.Text);
            }
        }
    }
}
