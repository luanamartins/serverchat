﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ServerChat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Controllers.AsynchronousSocketListener.StartListening();

            Application.Run(new Form1());
            /*
            while (true)
            {
                try
                {
                    IPAddress ipAd = IPAddress.Parse(RequestConstants.IP_ADDRESS);
                    // use local m/c IP address, and 
                    // use the same in the client

                    // Initializes the Listener 
                    TcpListener myList = new TcpListener(ipAd, RequestConstants.PORT);

                    // Start Listeneting at the specified port 
                    myList.Start();

                    Console.WriteLine("The server is running at port 8001...");
                    Console.WriteLine("The local End point is  :" +
                                      myList.LocalEndpoint);
                    Console.WriteLine("Waiting for a connection.....");

                    Socket s = myList.AcceptSocket();
                    Console.WriteLine("Connection accepted from " + s.RemoteEndPoint);

                    byte[] b = new byte[100];
                    int k = s.Receive(b);
                    Console.WriteLine("Recieved...");
                    for (int i = 0; i < k; i++)
                        Console.Write(Convert.ToChar(b[i]));

                    ASCIIEncoding asen = new ASCIIEncoding();
                    s.Send(asen.GetBytes("The string was recieved by the server."));
                    Console.WriteLine("\nSent Acknowledgement");
                    
                    s.Close();
                    myList.Stop();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Error..... " + e.StackTrace);
                }
            }*/
        }
    }
}
