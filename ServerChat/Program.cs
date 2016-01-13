using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Text;

using ServerChat.Controllers;

namespace ServerChat
{
    /**
     * http://www.codeproject.com/Articles/12286/Simple-Client-server-Interactions-using-C
     * 
     */

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Controllers.AsynchronousSocketListener.StartListening();

            Application.Run(new Form1());
            /*
            Controllers.AsynchronousSocketListener.StartListening();

            Application.Run(new Form1());*/

            while (true)
            {
                try
                {
                    ServerConfiguration.getInstance().Port = 8001;
                    IPAddress ipAd = IPAddress.Parse("127.0.0.1");
                    // use local m/c IP address, and 
                    // use the same in the client

                    // Initializes the Listener 
                    TcpListener tcpListener = new TcpListener(ipAd, ServerConfiguration.getInstance().Port);

                    /* Start Listeneting at the specified port */
                    tcpListener.Start();

                    Console.WriteLine("The server is running at port " + ServerConfiguration.getInstance().Port + "...");
                    Console.WriteLine("The local End point is  :" +
                                      tcpListener.LocalEndpoint);
                    Console.WriteLine("Waiting for a connection.....");

                    Socket socket = tcpListener.AcceptSocket();
                    Console.WriteLine("Connection accepted from " + socket.RemoteEndPoint);

                    byte[] b = new byte[100];
                    int k = socket.Receive(b);
                    Console.WriteLine("Received...");
                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(b[i]));

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    socket.Send(encoding.GetBytes("The string was recieved by the server."));
                    Console.WriteLine("\nSent Acknowledgement");
                    
                    socket.Close();
                    tcpListener.Stop();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error..... " + e.StackTrace);
                }
            }
        }
    }
}
