using LedCSharp;
using LoginGame;
using logitest1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logitest1
{
	internal class Obstacle
	{
		static Random random = new();

		static int move = 1;
		static int player = 1;
		static bool gameOver = false;

		static void ReadUserInput()
		{
			while (true)
			{
				ConsoleKeyInfo key = Console.ReadKey();

				switch (key.Key)
				{
					case ConsoleKey.UpArrow: move = -1; break;
					case ConsoleKey.DownArrow: move = 1; break;
					case ConsoleKey.Escape:
						LogitechGSDK.LogiLedShutdown();
						Environment.Exit(0);
						break;
				}
			}
		}

		static void Pipe()
		{
			int blank = random.Next(Common.Height);

			int x = Common.Width - 1;

			while (!gameOver)
			{
				for (int i = 0; i < Common.Height; i++)
				{
					if (i == blank) continue;
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[i, x], 0, 0, 0);
					if (x == 0) continue;
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[i, x - 1], 0, 255, 0);
				}

				if (x == 0)
				{
					if (blank != player) gameOver = true;
					break;
				}

				x--;
				Thread.Sleep(200);
			}
		}

		static void PipeGenerator()
		{
			while (!gameOver)
			{
				Thread newPipe = new(new ThreadStart(Pipe));
				newPipe.Start();
				Thread.Sleep(1000);
			}
		}

		static void Player()
		{
			while (!gameOver)
			{
				if (move != 0)
				{
					if (player + move < 0) continue;
					if (player + move >= Common.Height) continue;

					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[player, 0], 0, 0, 0);
					player += move;
					move = 0;
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[player, 0], 255, 255, 255);
				}
			}
		}

		public static void StartGame()
		{
			gameOver = false;
			Thread inputThread = new(new ThreadStart(ReadUserInput));
			inputThread.Start();

			Thread generator = new(new ThreadStart(PipeGenerator));
			generator.Start();

			Thread playerThread = new(new ThreadStart(Player));
			playerThread.Start();

			while (!gameOver);
		}
	}
}
