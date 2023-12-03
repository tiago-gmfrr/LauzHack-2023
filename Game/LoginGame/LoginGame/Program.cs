// See https://aka.ms/new-console-template for more information
using LedCSharp;
using LoginGame;
using logitest1;
using System.Drawing;
using System.Net;
using System.Net.Sockets;


LogitechGSDK.LogiLedInit();
LogitechGSDK.LogiLedSaveCurrentLighting();

//Animations.StartAnimation();

while (true)
{
    Animations.ClearKeyboard(Color.Black, Animations.Direction.Right);
    char game = Console.ReadKey().KeyChar.ToString().ToLower()[0];
    switch (game)
    {
        case '1':
            Animations.Wave(Color.Blue);
            Animations.Wave(Color.Blue, Animations.Direction.Left);
            Animations.Wave(Color.Blue, Animations.Direction.Down);
            TicTacToeManager manager = new TicTacToeManager();
            manager.Play();
            LogitechGSDK.LogiLedSetLighting(0, 0, 0);
            break;
        case '2':
            Animations.Wave(Color.Blue);
            Animations.Wave(Color.Blue, Animations.Direction.Left);
            Animations.Wave(Color.Blue, Animations.Direction.Down);
            MemoryGameManager memoryGameManager = new MemoryGameManager();
            memoryGameManager.Play();
            LogitechGSDK.LogiLedSetLighting(0, 0, 0);
            break;
        case '3':
            Animations.Wave(Color.Blue);
            Animations.Wave(Color.Blue, Animations.Direction.Left);
            Animations.Wave(Color.Blue, Animations.Direction.Down);
            Obstacle.StartGame();
            Animations.Wave(Color.Red);
            LogitechGSDK.LogiLedSetLighting(0, 0, 0);
            break;
    }
}
Console.ReadLine();
LogitechGSDK.LogiLedShutdown();




