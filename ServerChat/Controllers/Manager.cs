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
        public static int NumberOfUsers;
        public static int NumberOfMessages;
        public List<String> listOfOnlineUsers;

        public static void changeNumberUsers(int number) 
        {
            NumberOfUsers = number;
        }

        public static void changeNumberOfMessages(int number) 
        {
            NumberOfMessages = number;    
        }

        public void processRequest() 
        {

            IPAddress ipAddress = IPAddress.Parse(RequestConstants.IP_ADDRESS);
            int port = RequestConstants.PORT;
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
