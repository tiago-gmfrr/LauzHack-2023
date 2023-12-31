﻿// See https://aka.ms/new-console-template for more information
using System.Net.Sockets;
using System.Net;
using System.Text;

Console.WriteLine("Hello, World!");

Thread serverThread = new(new ThreadStart(ServerHost));
serverThread.Start();


static void ServerHost()
{
    // Establish the local endpoint 
    // for the socket. Dns.GetHostName
    // returns the name of the host 
    // running the application.
	IPEndPoint localEndPoint = new(IPAddress.Parse("10.177.88.191"), 11111);
	Console.WriteLine($"{nameof(localEndPoint)} : {localEndPoint}");

    // Creation TCP/IP Socket using 
    // Socket Class Constructor
    Socket listener = new Socket(localEndPoint.AddressFamily,
                 SocketType.Stream, ProtocolType.Tcp);

    try
    {

        // Using Bind() method we associate a
        // network address to the Server Socket
        // All client that will connect to this 
        // Server Socket must know this network
        // Address
        listener.Bind(localEndPoint);

        // Using Listen() method we create 
        // the Client list that will want
        // to connect to Server
        listener.Listen(10);

        while (true)
        {

            Console.WriteLine("Waiting connection ... ");

            // Suspend while waiting for
            // incoming connection Using 
            // Accept() method the server 
            // will accept connection of client
            Socket clientSocket = listener.Accept();

            // Data buffer
            byte[] bytes = new Byte[1024];
            string data = null;

            byte[] message = Encoding.ASCII.GetBytes("Test Server");
            while (true)
            {

                int numByte = clientSocket.Receive(bytes);

                data += Encoding.ASCII.GetString(bytes,
                                           0, numByte);

                if (data.IndexOf("<EOF>") > -1)
                    Console.WriteLine(data.IndexOf("ping/"));
                    if (data.IndexOf("ping/") > -1)
                    {
                        message = Encoding.ASCII.GetBytes("PING Server");
                    }
                    break;
            }

            Console.WriteLine("Text received -> {0} ", data);

            // Send a message to Client 
            // using Send() method
            clientSocket.Send(message);

            while (true)
            {

            }

            // Close client Socket using the
            // Close() method. After closing,
            // we can use the closed Socket 
            // for a new Client Connection
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }

    catch (Exception e)
    {
        Console.WriteLine(e.ToString());
    }
}
