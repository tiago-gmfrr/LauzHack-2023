using SocketIOClient;

namespace Bruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var client = new SocketIO("http://34.65.206.69:30992");


            client.OnConnected += async (sender, e) =>
            {
                // Emit a string
                await client.EmitAsync("Hello World");

            };
            client.ConnectAsync();

            //var options = new IO.Options();
            //options.AutoConnect = false;
            //options.Transports = ImmutableList.Create<string>("websocket");
            //var tmp = new List<string>
            //{
            //    "websocket"
            //};
            //options.Transports = tmp;
            //var test = IO.Socket("http://34.65.206.69:30992/", options);
            //test.Connect();
            //test.On(Socket.EVENT_CONNECT, () =>
            //{
            //    Console.WriteLine("Connected to the server");

            //    // Send a message to the server
            //    test.Emit("chat message", "Hello, server!");
            //});
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            string roomName = tbxRoomName.Text;
            //SocketIOClient s = SocketClient.getSocketClient();
            //s.Emit("Hello World", s);
            //s.Emit("connection", s);

            //s.Emit("createRoom", roomName);
        }
    }
}
