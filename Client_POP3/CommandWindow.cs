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
    public partial class CommandWindow : Form
    {
        private int parsedNumber;
        LOGScreen log;
        ServerConScreen serCon;
        public CommandWindow(LOGScreen log ,ServerConScreen serCon)
        {
            this.serCon = serCon;
            this.log = log;
            InitializeComponent();
        }
        

        private void LIST_CheckedChanged(object sender, EventArgs e)
        {
            if (LIST.Checked)
            {
                msgBox.ReadOnly = false;
                nBox.ReadOnly = true;
            }
        }

        private void STAT_CheckedChanged(object sender, EventArgs e)
        {
            if (STAT.Checked)
            {
                msgBox.ReadOnly = true;
                nBox.ReadOnly = true;
            }
        }

        private void QUIT_CheckedChanged(object sender, EventArgs e)
        {
            if (QUIT.Checked)
            {
                msgBox.ReadOnly = true;
                nBox.ReadOnly = true;
            }
        }

        private void RETR_CheckedChanged(object sender, EventArgs e)
        {
            if (RETR.Checked)
            {
                msgBox.ReadOnly = false;
                nBox.ReadOnly = true;
            }
        }

        private void DELE_CheckedChanged(object sender, EventArgs e)
        {
            if (DELE.Checked)
            {
                msgBox.ReadOnly = false;
                nBox.ReadOnly = true;
            }
        }

        private void NOOP_CheckedChanged(object sender, EventArgs e)
        {
            if (NOOP.Checked)
            {
                msgBox.ReadOnly = true;
                nBox.ReadOnly = true;
            }
        }

        private void RSET_CheckedChanged(object sender, EventArgs e)
        {
            if (RSET.Checked)
            {
                msgBox.ReadOnly = true;
                nBox.ReadOnly = true;
            }
        }

        private void TOP_CheckedChanged(object sender, EventArgs e)
        {
            if (TOP.Checked)
            {
                msgBox.ReadOnly = false;
                nBox.ReadOnly = false;
            }
        }

        private void UIDL_CheckedChanged(object sender, EventArgs e)
        {
            if (UIDL.Checked)
            {
                msgBox.ReadOnly = false;
                nBox.ReadOnly = true;
            }
        }

        private void ExcecuteButton_Click(object sender, EventArgs e)
        {
            if (LIST.Checked)
            {
                
                bool parsed = parseNumber(msgBox.Text);
                log.LOGBox.AppendText("C: LIST " + msgBox.Text + "\r\n", Color.DarkCyan);
                if (parsed == true)
                {
                    
                    string result = Client.LIST(this.parsedNumber);
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                else
                {
                    string result = Client.LIST();
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
            }
            if (STAT.Checked)
            {
                log.LOGBox.AppendText("C: STAT \r\n", Color.DarkCyan);
                log.LOGBox.AppendText("S: " + Client.STAT() + "\r\n", Color.ForestGreen);
            }
            if (QUIT.Checked)
            {
                log.LOGBox.AppendText("C: QUIT \r\n", Color.DarkCyan);
                log.LOGBox.AppendText("S: " + Client.QUIT() + "\r\n", Color.ForestGreen);
                this.Hide();
                serCon.Show();

            }
            if (RETR.Checked)
            {
                bool parsed = parseNumber(msgBox.Text);
                log.LOGBox.AppendText("C: RETR " + msgBox.Text + "\r\n", Color.DarkCyan);
                if (parsed == true)
                {
                    string result = Client.RETR(this.parsedNumber);
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                else
                {
                    log.LOGBox.AppendText("C: -ERR incorect format (expected number) " + "\r\n", Color.Red);
                }
            }
            if (DELE.Checked)
            {
                bool parsed = parseNumber(msgBox.Text);
                log.LOGBox.AppendText("C: DELE " + msgBox.Text + "\r\n", Color.DarkCyan);
                if (parsed == true)
                {
                    string result = Client.DELE(this.parsedNumber);
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                else
                {
                    log.LOGBox.AppendText("C: -ERR incorect format (expected number) " + "\r\n", Color.Red);
                }
            }
            if(NOOP.Checked)
            {
                log.LOGBox.AppendText("C: NOOP" + "\r\n", Color.DarkCyan);
                string result = Client.NOOP();
                log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
            }
            if(RSET.Checked)
            {
                
                log.LOGBox.AppendText("C: RSET \r\n", Color.DarkCyan);
                string result = Client.RSET();
                log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                
               
            }
            if (TOP.Checked)
            {
                int msg;
                int n;
                bool parsed = parseNumber(msgBox.Text);
                msg = parsedNumber;
                bool parsed2 = parseNumber(nBox.Text);
                n = parsedNumber;
                log.LOGBox.AppendText("C: TOP " + msgBox.Text + " " + n + "\r\n", Color.DarkCyan);
                
                if (parsed && parsed2)
                {
                    string result = Client.TOP(msg,n);
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                else
                {
                    log.LOGBox.AppendText("C: -ERR incorect format (expected number) " + "\r\n", Color.Red);
                }
            }
            if (UIDL.Checked)
            {
                int msg;
                
                bool parsed = parseNumber(msgBox.Text);
                msg = parsedNumber;
                log.LOGBox.AppendText("C: UIDL " + msgBox.Text + "\r\n", Color.DarkCyan);
                if (parsed )
                {
                    string result = Client.UIDL(msg);
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                else
                {
                    string result = Client.UIDL();
                    log.LOGBox.AppendText("S: " + result + "\r\n", Color.ForestGreen);
                }
                
            }
            
        }
        private bool parseNumber(string number)
        {
            return int.TryParse(number ,out this.parsedNumber);
        }
    }
}
