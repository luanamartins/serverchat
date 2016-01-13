using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.Net.Sockets;

namespace ServerChat.Controllers
{
    class Manager
    {

        public static int NumberOfUsers { get; set; }
        public static int NumberOfMessages { get; set; }
        
        public void processRequest() 
        {

            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = ServerConfiguration.getInstance().Port;
            TcpListener tcpListener = new TcpListener(ipAddress, port);
            
            tcpListener.Start();
            
            Console.WriteLine("The server is running at port " + port + " ...");
            Console.WriteLine("The local end point is: " + tcpListener.LocalEndpoint);
            Socket socket = tcpListener.AcceptSocket();
            Console.WriteLine("Connection accepted from " + socket.RemoteEndPoint);

            byte[] byteArrayMessage = new byte[100];
            int k = socket.Receive(byteArrayMessage);
            Console.WriteLine("Received...");
            for (int i = 0; i < k; i++) 
            {
                Console.Write(Convert.ToChar(byteArrayMessage[i]));
            }

            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            socket.Send(asciiEncoding.GetBytes("The string was received by the server."));
            Console.WriteLine("\nSent acknowledgement");

            socket.Close();
            tcpListener.Stop();

        }

        public void loginRequest(string username, string password) 
        {
            
        }
    }
}
