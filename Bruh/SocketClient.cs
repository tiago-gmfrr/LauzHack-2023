﻿
namespace Bruh
{
    public class SocketClient
    {
        const string HOST = "34.65.206.69";
        const int PORT = 30992;

        //private static var _socket;
        private static string socketId;
        private SocketClient()
        {
            //_socket = new SocketIOClient(new SocketIOClientOption(EngineIOScheme.http, HOST, PORT));
            //_socket.Connect();
            //_socket.On()
            //_socket.On("roomCreated", (response) => Console.WriteLine(response.Data));
            //_socket.On("roomJoined", (response) => socketId = response.Data.ToString());
            //_socket.On("roomLeft", (response) => socketId = response.Data.ToString());
            //_socket.On("gameChosen", (response) => Console.WriteLine(response.Data));
            //_socket.On("gameAction", (response) => socketId = response.Data.ToString());
        }
    
        public static string SocketId { get => socketId;}

        //public static SocketIOClient getSocketClient()
        //{
        //    //if (_socket == null)
        //    //{
        //    //    new SocketClient();
        //    //}

        //    //return _socket;
        //}


        //public void ExecuteClient()
        //{

        //    try
        //    {

        //        //// Establish the remote endpoint 
        //        //// for the socket. This example 
        //        //// uses port 11111 on the local 
        //        //// computer.
        //        //IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
        //        //IPAddress ipAddr = ipHost.AddressList[0];
        //        //IPEndPoint localEndPoint = new IPEndPoint(ipAddr, 11111);

        //        //// Creation TCP/IP Socket using 
        //        //// Socket Class Constructor
        //        //Socket sender = new Socket(ipAddr.AddressFamily,
        //        //           SocketType.Stream, ProtocolType.Tcp);

        //        try
        //        {

        //            // Connect Socket to the remote 
        //            // endpoint using method Connect()


        //            // We print EndPoint information 
        //            // that we are connected
        //            Console.WriteLine("Socket connected to -> {0} ",
        //                          _socket.RemoteEndPoint.ToString());

        //            // Creation of message that
        //            // we will send to Server
        //            byte[] messageSent = Encoding.ASCII.GetBytes("Test Client<EOF>");
        //            int byteSent = _socket.Send(messageSent);



        //            // Data buffer
        //            byte[] messageReceived = new byte[1024];

        //            // We receive the message using 
        //            // the method Receive(). This 
        //            // method returns number of bytes
        //            // received, that we'll use to 
        //            // convert them to string
        //            int byteRecv = _socket.Receive(messageReceived);
        //            Console.WriteLine("Message from Server -> {0}",
        //                  Encoding.ASCII.GetString(messageReceived,
        //                                             0, byteRecv));

        //            // Close Socket using 
        //            // the method Close()
        //            _socket.Shutdown(SocketShutdown.Both);
        //            _socket.Close();
        //        }

        //        // Manage of Socket's Exceptions
        //        catch (ArgumentNullException ane)
        //        {

        //            Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
        //        }

        //        catch (SocketException se)
        //        {

        //            Console.WriteLine("SocketException : {0}", se.ToString());
        //        }

        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Unexpected exception : {0}", e.ToString());
        //        }
        //    }

        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e.ToString());
        //    }
        //}
    }
}
