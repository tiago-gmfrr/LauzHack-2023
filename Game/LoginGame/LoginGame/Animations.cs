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
            int x = random.Next(Common.Width);
            int y = random.Next(Common.Height);

            int speedX = 1;
            int speedY = 1;

            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[y, x], 0, 0, 0);
                x += speedX;
                y += speedY;

                if (x < 0)
                {
                    speedX *= -1;
                    x = 1;
                }
                else if (x >= Common.Width)
                {
                    speedX *= -1;
                    x = Common.Width - 1;
                }

                if (y < 0)
                {
                    speedY *= -1;
                    y = 1;
                }
                else if (y >= Common.Height)
                {
                    speedY *= -1;
                    y = Common.Height - 1;
                }

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)Common.keys[y, x], 0, 255, 0);
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
			for (int x = 0; x < Common.Width; x++)
			{
				for (int y = 0; y < Common.Height; y++)
				{
					keyboardNames key = (keyboardNames)Common.keys[y, direction == Direction.Right ? x : Common.Width - x - 1];
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
				}
				Thread.Sleep(25);
			}
		}

        public static void ClearKeyboard(Color color, Direction direction)
        {
            for (int x = 0; x < Common.Width; x++)
            {
                for (int y = 0; y < Common.Height; y++)
                {
                    keyboardNames key = (keyboardNames)Common.keys[y, direction == Direction.Right ? x : Common.Width - x - 1];
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
                }
            }
        }

        private static void WaveAnimationVertical(Color color, Direction direction)
		{
			for (int y = 0; y < Common.Height; y++)
			{
				for (int x = 0; x < Common.Width; x++)
				{
					keyboardNames key = (keyboardNames)Common.keys[direction == Direction.Down ? y : Common.Height - y - 1, x];
					LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, color.R, color.G, color.B);
				}
				Thread.Sleep(25);
			}
		}

        public static void Glow(Color color, int x, int y)
        {
            GlowUp(color, x, y);
            GlowDown(color, x, y);
        }

        public static void Glow(Color color, keyboardNames key)
        {
            GlowUp(color, key);
            GlowDown(color, key);
        }

        public static void GlowUp(Color color, int x, int y)
        {
            for (float i = 0; i <= 1; i += .1f)
            {
                keyboardNames key = (keyboardNames)Common.keys[x, y];
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, (int)(color.R * i), (int)(color.G * i), (int)(color.B * i));
                Thread.Sleep(50);
            }
        }

        public static void GlowUp(Color color, keyboardNames key)
        {
            for (float i = 0; i <= 1; i += .1f)
            {
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, (int)(color.R * i), (int)(color.G * i), (int)(color.B * i));
                Thread.Sleep(50);
            }
        }

        public static void GlowDown(Color color, int x, int y)
        {
            for (float i = 1; i >= 0; i -= .1f)
            {
                keyboardNames key = (keyboardNames)Common.keys[x, y];
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, (int)(color.R * i), (int)(color.G * i), (int)(color.B * i));
                Thread.Sleep(50);
            }
        }
        public static void GlowDown(Color color, keyboardNames key)
        {
            for (float i = 1; i >= 0; i -= .1f)
            {
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(key, (int)(color.R * i), (int)(color.G * i), (int)(color.B * i));
                Thread.Sleep(50);
            }
        }
    }
}