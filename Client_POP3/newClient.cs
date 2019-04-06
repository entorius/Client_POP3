using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Security;
using System.Threading;
using System.Drawing;
//using System.Web.Mail;

namespace Client_POP3
{
    public class newClient
    {

        private string CRLF = "\r\n";
        private TcpClient Server;
        private StreamReader reader;
        public StreamWriter sw;
        private SslStream sslStream;
        private string strTemp = string.Empty;
        private string str = string.Empty;
        public newClient()
        {
           
        }
        public string connectToServer(string _Server)
        {
            try
            {
                this.Server = new TcpClient(_Server, 995);
                sslStream = new SslStream(Server.GetStream());
                sslStream.AuthenticateAsClient(_Server);
                this.reader = new StreamReader(sslStream);
                this.sw = new StreamWriter(sslStream);
                strTemp = reader.ReadLine();
                Console.WriteLine(strTemp + "Welcome");
                return "S: +OK";
            }
            catch (ArgumentNullException e)
            {
                return "C: -ERR ArgumentNullException";
            }
            catch (SocketException e)
            {
                return "S: -ERR SocketException";
            }
        }

        public string USER(string _User)
        {
            sw.WriteLine("USER" + " " + _User);
            sw.Flush();
            strTemp = reader.ReadLine();
            Console.WriteLine(strTemp + " user"+ "\r\n");
            
            return strTemp;
        }
        public string PASS(string _Password)
        {
            sw.WriteLine("PASS" + " " + _Password);
            sw.Flush();
            strTemp = reader.ReadLine();
            Console.WriteLine(strTemp + "\r\n");
            return strTemp;
        }
        
        public string STAT()
        {
            sw.WriteLine("STAT");
            sw.Flush();
            strTemp = reader.ReadLine();

            return strTemp;
        }
        public string LIST(int msg = -1)
        {
            if (msg == -1)
            {
                sw.WriteLine("LIST");
                sw.Flush();
                strTemp = reader.ReadLine();
            }
            else
            {
                string number = msg.ToString();
                sw.WriteLine("LIST " + number);
                sw.Flush();
                strTemp = reader.ReadLine();
            }

            return strTemp;
        }
        public string RETR(int msg)
        {
            sw.WriteLine("retr " + msg + "\r\n");
            sw.Flush();
            while (true)
            {
                string line;
                
                    line = reader.ReadLine();
                if (line == "-ERR Command not understood")
                {
                    break;
                }
                    strTemp = strTemp + line;
            }
            strTemp = strTemp + this.CRLF;

            return strTemp;
        }
        
        public string DELE(int msg)
        {
            string number = msg.ToString();
            sw.WriteLine("DELE " + number);
            sw.Flush();
            strTemp = reader.ReadLine();

            return strTemp;
        }
        public string NOOP()
        {
            sw.WriteLine("NOOP");
            sw.Flush();
            strTemp = reader.ReadLine();

            return strTemp;
        }
        public string RSET()
        {
            sw.WriteLine("RSET");
            sw.Flush();
            strTemp = reader.ReadLine();

            return strTemp;
        }
        public string QUIT( )
        {
            sw.WriteLine("QUIT");
            sw.Flush();
            strTemp = reader.ReadLine();

            return strTemp;
        }
        public string TOP(int msg, int n)
        {
            sw.WriteLine("TOP " + msg + " " + n + "\r\n");
            sw.Flush();
            int counter = 1;
            strTemp = reader.ReadLine();
            strTemp = strTemp + "/r/n";
            if (strTemp[0] == '-' && strTemp[0] == 'E' && strTemp[0] == 'R' && strTemp[0] == 'R')
            {
            }
            else
            {
                while (counter<=n )
                {
                    string line;

                    line = reader.ReadLine();
                    Console.WriteLine(line);
                    if (line == "-ERR Command not understood")
                    {
                        break;
                    }
                    strTemp = strTemp +  "S: " + counter.ToString() + " " + line + "\r\n";
                    counter = counter + 1;
                }
            }
            return strTemp;
        }
        public string UIDL(int msg = -1)
        {
            int counter = 1;
            if (msg <= -1)
            {
                sw.WriteLine("UIDL\r\n");
            }
            else
            {
                sw.WriteLine("UIDL " + msg + "\r\n");
            }
            sw.Flush();
            strTemp = reader.ReadLine();
            if (strTemp[0] == '-' && strTemp[0] == 'E' && strTemp[0] == 'R' && strTemp[0] == 'R')
            {
            }
            else
            {
                while (true)
                {
                    string line;

                    line = reader.ReadLine();
                    Console.WriteLine(line);
                    if (line == "-ERR Command not understood")
                    {
                        break;
                    }
                    strTemp = strTemp + "S: "+ counter.ToString() +" "+ line + "\r\n";
                    counter = counter + 1;
                }
            }
            return strTemp;
        }
        public string APOP(string username, string password)
        {
            string hash = Encryptor.MD5Hash("<" + Client.server + ">" + password);
            Client.log.LOGBox.AppendText("C: APOP " + username + " " + password + " encrypted" + hash +" \r\n", Color.DarkCyan);
            sw.WriteLine("APOP "+username+ " " + hash +"\r\n");
            sw.Flush();
            strTemp = reader.ReadLine();
            Client.log.LOGBox.AppendText("S: " +strTemp + "\r\n");

            return strTemp;
        }
    }
}
