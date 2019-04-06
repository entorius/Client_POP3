using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using LumiSoft.Net.POP3;

namespace Client_POP3
{
    public static class Client
    {
        //windows
        public static CommandWindow commandWin;
        public static Login_Register_Screen loginsc;
        public static LOGScreen log;
        public static ServerConScreen servCon;
        //events
        delegate void SetTextCallback(string text);
        //server facilities
        public static NetworkStream stream;
        public static TcpClient clientserver;
        public static  newClient client;
        public static string server;

        public static void ClientConnected(ServerConScreen servCon)
        {
            commandWin = new CommandWindow(log, servCon);
            commandWin.Show();
            loginsc.Hide();
        }

        public static void ClientIni()
        {
            log = new LOGScreen();
            log.Show();
        }
        
        public static void showLoginScreen(ServerConScreen serverSc , string server)
        {
            Client.server = server;
            if (loginsc == null)
            {
                loginsc = new Login_Register_Screen(log, serverSc);
            }
            loginsc.Show();
        }
        
        public static void StartClient()
        {

           client = new newClient();
           
        }
        
        
        public static string STAT()
        {
            return client.STAT();
        }
        public static string LIST(int msg = -1)
        {
            return client.LIST(msg);
        }
        public static string RETR(int msg)
        {
            return client.RETR(msg);
        }
        public static string DELE(int msg)
        {
           
            return client.DELE(msg);
        }
        public static string NOOP()
        {
            return client.NOOP();
        }
        public static string RSET()
        {
            return client.RSET();
        }
        public static string QUIT()
        {
            return client.QUIT();
        }
        public static string TOP(int msg, int n)
        {
            return client.TOP(msg, n);
        }
        public static string UIDL(int msg = -1)
        {
            if (msg > -1)
            {
                return client.UIDL(msg);
            }
            else
            {
                return client.UIDL();
            }
        }
        public static string USER(string name)
        {
            return client.USER(name);
        }
        public static string PASS(string pass)
        {
            return client.PASS(pass);
        }
        public static string APOP(string name, string digest)
        {
            //TODO if i will have a time
            return client.APOP(name,digest);
        }
    }
}
