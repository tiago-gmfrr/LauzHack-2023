using LedCSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
    internal class Comon
    {

        public static Dictionary<char, keyboardNames> GetKeys()
        {
            Dictionary<char, keyboardNames> color_keys_dic = new Dictionary<char, keyboardNames>
            {
                { 'a', keyboardNames.A },
                { 'b', keyboardNames.B },
                { 'c', keyboardNames.C },
                { 'd', keyboardNames.D },
                { 'e', keyboardNames.E },
                { 'f', keyboardNames.F },
                { 'g', keyboardNames.G },
                { 'h', keyboardNames.H },
                { 'i', keyboardNames.I },
                { 'j', keyboardNames.J },
                { 'k', keyboardNames.K },
                { 'l', keyboardNames.L },
                { 'm', keyboardNames.M },
                { 'n', keyboardNames.N },
                { 'o', keyboardNames.O },
                { 'p', keyboardNames.P },
                { 'q', keyboardNames.Q },
                { 'r', keyboardNames.R },
                { 's', keyboardNames.S },
                { 't', keyboardNames.T },
                { 'u', keyboardNames.U },
                { 'v', keyboardNames.V },
                { 'w', keyboardNames.W },
                { 'x', keyboardNames.X },
                //{ 'y', keyboardNames.Y },
                //{ 'z', keyboardNames.Z }
            };
            return color_keys_dic;
        }

        public static int[,] keys = {
            { 0x29, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E },
            { 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C },
            { 0x3A, 0x1E, 0x1F, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x1C },
            { 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x36 },
            { 0x1D, 0x15B, 0x38, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x39, 0x138, 0x15C, 0x15D, 0x11D }
        };

        public const int Width = 14;
        public const int Height = 5;
    }

}
