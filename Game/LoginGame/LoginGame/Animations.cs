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