﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerSocket
{
	internal class Connection
	{
		private List<Socket> _connection = new List<Socket>();
		private Connection()
		{
			Thread listenThread = new(new ThreadStart(listen));
			listenThread.Start();
		}

		private void listen()
		{
			while (true)
			{
				Socket listener = SocketConnection.GetSocket();
				Socket clientSocket = listener.Accept();
				_connection.Add(clientSocket);
			}
		}


		public List<Socket> GetSockets()
		{
			return _connection;
		}

	}
}
