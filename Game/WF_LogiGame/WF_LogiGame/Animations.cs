using LedCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
    internal class Animations
    {

        public static void Start_Animation()
        {
            int width = 14;
            int height = 5;

            int[,] keys = {
                {0x29, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E },
                {0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C },
                {0x3A, 0x1E, 0x1F, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x1C },
                {0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x36 },
                {0x1D, 0x15B, 0x38, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x138, 0x15C, 0x15D, 0x11D }
};

            Random random = new();
            int x = random.Next(width);
            int y = random.Next(height);

            int speedX = 1;
            int speedY = 1;

            for (int i = 0; i < 40; i++)
            {
                Thread.Sleep(100);
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)keys[y, x], 0, 0, 0);
                x += speedX;
                y += speedY;

                if (x < 0)
                {
                    speedX *= -1;
                    x = 1;
                }
                else if (x >= width)
                {
                    speedX *= -1;
                    x = width - 1;
                }

                if (y < 0)
                {
                    speedY *= -1;
                    y = 1;
                }
                else if (y >= height)
                {
                    speedY *= -1;
                    y = height - 1;
                }

                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName((keyboardNames)keys[y, x], 255, 255, 255);
            }
        }
    }
}
