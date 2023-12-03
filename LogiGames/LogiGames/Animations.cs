using LedCSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
	internal class Animations
	{
        public enum Direction { Right, Left, Up, Down }

		public static void StartAnimation()
		{
            Random random = new();
            int x = random.Next(Comon.Width);
            int y = random.Next(Comon.Height);

            int speedX = 1;
            int speedY = 1;

            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Comon.keys[y, x], 0, 0, 0);
                x += speedX;
                y += speedY;

                if (x < 0)
                {
                    speedX *= -1;
                    x = 1;
                }
                else if (x >= Comon.Width)
                {
                    speedX *= -1;
                    x = Comon.Width - 1;
                }

                if (y < 0)
                {
                    speedY *= -1;
                    y = 1;
                }
                else if (y >= Comon.Height)
                {
                    speedY *= -1;
                    y = Comon.Height - 1;
                }

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Comon.keys[y, x], 0, 255, 0);
            }
        }

        public static void Wave(Color color, Direction direction = Direction.Right)
		{
			Wave(color, Color.Black, direction);
		}

		public static void Wave(Color color, Color eraseColor, Direction direction = Direction.Right)
		{
			switch (direction)
			{
				case Direction.Right:
				case Direction.Left:
					WaveAnimation(color, direction);
					WaveAnimation(eraseColor, direction);
					break;
				case Direction.Up:
				case Direction.Down:
					WaveAnimationVertical(color, direction);
					WaveAnimationVertical(eraseColor, direction);
					break;
			}
		}

		private static void WaveAnimation(Color color, Direction direction)
		{
			for (int x = 0; x < Comon.Width; x++)
			{
				for (int y = 0; y < Comon.Height; y++)
				{
					keyboardNames key = (keyboardNames)Comon.keys[y, direction == Direction.Right ? x : Comon.Width - x - 1];
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
				}
				Thread.Sleep(50);
			}
		}

        public static void ClearKeyboard(Color color, Direction direction)
        {
            for (int x = 0; x < Comon.Width; x++)
            {
                for (int y = 0; y < Comon.Height; y++)
                {
                    keyboardNames key = (keyboardNames)Comon.keys[y, direction == Direction.Right ? x : Comon.Width - x - 1];
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
                }
            }
        }

        private static void WaveAnimationVertical(Color color, Direction direction)
		{
			for (int y = 0; y < Comon.Height; y++)
			{
				for (int x = 0; x < Comon.Width; x++)
				{
					keyboardNames key = (keyboardNames)Comon.keys[direction == Direction.Down ? y : Comon.Height - y - 1, x];
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
				}
				Thread.Sleep(50);
			}
		}
	}
}