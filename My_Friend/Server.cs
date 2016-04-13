using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace My_Friend
{
    public class Server
    {
        My_Friend obj = new My_Friend();
        private TcpListener tcpListener;
        public void Server1()
        {

            StartServer();
            
        }

        public string myip()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        public bool StartServer()
        {


            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8080);
                tcpListener.Start();
                tcpListener.BeginAcceptTcpClient(new AsyncCallback(this.ProcessEvents), tcpListener);

              //  Console.WriteLine("Listing at Port {0}.", 8080);
            }
            catch (Exception e)
            {
         //       Console.WriteLine(e.ToString());
                return false;
            }

            return true;
        }

        private void ProcessEvents(IAsyncResult asyn)
        {
            try
            {
                TcpListener processListen = (TcpListener)asyn.AsyncState;
                TcpClient tcpClient = processListen.EndAcceptTcpClient(asyn);
                NetworkStream myStream = tcpClient.GetStream();
                if (myStream.CanRead)
                {
                    StreamReader readerStream = new StreamReader(myStream);
                    string myMessage = readerStream.ReadToEnd();
                    //   Console.WriteLine("The Message is " + myMessage);
                    obj.reply(myMessage);
                    readerStream.Close();
                }
                myStream.Close();
                tcpClient.Close();
                tcpListener.BeginAcceptTcpClient(new AsyncCallback(this.ProcessEvents), tcpListener);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


    }
}
