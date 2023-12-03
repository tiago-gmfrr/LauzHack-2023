using System.Net.Sockets;
using System.Net;
using System.Text;

namespace LogiGames
{
	public partial class Form1 : Form
	{
		bool disconnect = false;
		Socket socket;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ExecuteClient();
		}

		void ExecuteClient()
		{
			try
			{
				// Establish the remote endpoint 
				// for the socket. This example 
				// uses port 11111 on the local 
				// computer.
				IPEndPoint localEndPoint = new(IPAddress.Parse("10.177.88.191"), 11111);

				// Creation TCP/IP Socket using 
				// Socket Class Constructor
				Socket sender = new Socket(localEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

				try
				{
					// Connect Socket to the remote 
					// endpoint using method Connect()
					sender.Connect(localEndPoint);

					// We print EndPoint information 
					// that we are connected
					Console.WriteLine("Socket connected to -> {0} ",
								  sender.RemoteEndPoint.ToString());

					// Creation of message that
					// we will send to Server
					byte[] messageSent = Encoding.ASCII.GetBytes("BOLOSS");
					int byteSent = sender.Send(messageSent);

					//Thread client = new(new ThreadStart(() => ReceiveData(sender)));
					//client.Start();

					socket = sender;
				}

				// Manage of Socket's Exceptions
				catch (ArgumentNullException ane)
				{
					Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
				}

				catch (SocketException se)
				{
					Console.WriteLine("SocketException : {0}", se.ToString());
				}

				catch (Exception e)
				{
					Console.WriteLine("Unexpected exception : {0}", e.ToString());
				}
			}

			catch (Exception e)
			{
				Console.WriteLine(e.ToString());
			}
		}

		void ReceiveData(Socket sender)
		{
			// Data buffer
			byte[] messageReceived = new byte[1024];
			while (!disconnect)
			{
				// We receive the message using
				// the method Receive(). This 
				// method returns number of bytes
				// received, that we'll use to 
				// convert them to string
				int byteRecv = sender.Receive(messageReceived);
				Console.WriteLine("Message from Server -> {0}",
					  Encoding.ASCII.GetString(messageReceived,
												 0, byteRecv));
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close Socket using 
			// the method Close()
			socket.Shutdown(SocketShutdown.Both);
			socket.Close();
			disconnect = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			byte[] messageSent = Encoding.ASCII.GetBytes("Start Game<EOF>");
			int byteSent = socket.Send(messageSent);
		}
	}
}
