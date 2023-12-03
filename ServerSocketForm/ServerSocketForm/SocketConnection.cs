using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocketForm
{
	internal class SocketConnection
	{
		private static Socket _socket;
		private static IPHostEntry _entry;
		private static IPAddress _address;
		private static IPEndPoint _ep;
		private SocketConnection()
		{
			// Establish the local endpoint 
			// for the socket. Dns.GetHostName
			// returns the name of the host 
			// running the application.
			_entry = Dns.GetHostEntry(Dns.GetHostName());
			Console.WriteLine($"{nameof(_entry)} : {_entry}");
			_address = _entry.AddressList[0];
			Console.WriteLine($"{nameof(_address)} : {_address}");
			_ep = new IPEndPoint(_address, 11111);
			Console.WriteLine($"{nameof(_ep)} : {_ep}");

			// Creation TCP/IP Socket using 
			// Socket Class Constructor
			_socket = new Socket(_address.AddressFamily,
						 SocketType.Stream, ProtocolType.Tcp);


			// Using Bind() method we associate a
			// network address to the Server Socket
			// All client that will connect to this 
			// Server Socket must know this network
			// Address
			_socket.Bind(_ep);

			// Using Listen() method we create 
			// the Client list that will want
			// to connect to Server
			_socket.Listen(10);

		}

		public static Socket GetSocket()
		{
			if (_socket == null)
			{
				new SocketConnection();
			}
			return _socket;
		}

		public static IPHostEntry GetHostEntry()
		{
			if (_entry == null)
			{
				new SocketConnection();
			}
			return _entry;
		}

		public static IPAddress GetIpAddress()
		{
			if (_address == null)
			{
				new SocketConnection();
			}
			return _address;
		}

		public static IPEndPoint GetIpEndpoint()
		{
			if (_ep == null)
			{
				new SocketConnection();
			}
			return _ep;
		}
	}
}
