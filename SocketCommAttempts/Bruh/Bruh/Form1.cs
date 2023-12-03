//using Quobject.Collections.Immutable;
//using Quobject.SocketIoClientDotNet.Client;
//using System.Net.Sockets;

using System.Net.Http.Headers;
using System.Net.Http;
using System.Security.Policy;

namespace Bruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


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
