//using Quobject.EngineIoClientDotNet.Client;
using WebSocketSharp;

namespace Bruh
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // Define the Socket.IO server URL
            var serverUrl = "http://127.0.0.1:30992";

            using (var ws = new WebSocket("ws://127.0.0.1:30992"))
            {
                ws.OnMessage += (sender, e) =>
                {
                    Console.WriteLine($"Received message: {e.Data}");
                };

                ws.Connect();

                if (ws.ReadyState == WebSocketState.Open)
                {

                    ws.Send("Hello World");
                    ws.Send("bruh");
                }

                //Console.ReadKey(true);
            }


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }

        
    }
}