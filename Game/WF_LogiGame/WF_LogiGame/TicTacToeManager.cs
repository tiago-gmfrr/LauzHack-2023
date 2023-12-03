using LedCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
    internal class TicTacToeManager
    {
        Dictionary<char, keyboardNames> color_keys_dic = new Dictionary<char, keyboardNames>();


        public TicTacToeManager()
        {
            
            color_keys_dic.Add('w', keyboardNames.W);
            color_keys_dic.Add('e', keyboardNames.E);
            color_keys_dic.Add('r', keyboardNames.R);
            color_keys_dic.Add('s', keyboardNames.S);
            color_keys_dic.Add('d', keyboardNames.D);
            color_keys_dic.Add('f', keyboardNames.F);
            color_keys_dic.Add('x', keyboardNames.X);
            color_keys_dic.Add('c', keyboardNames.C);
            color_keys_dic.Add('v', keyboardNames.V);
        }

        private void InitializeBoard()
        {
            List<keyboardNames> game_board = [keyboardNames.ONE,
                keyboardNames.Z,
                keyboardNames.A,
                keyboardNames.Q,
                keyboardNames.TWO,
                keyboardNames.THREE,
                keyboardNames.FOUR,
                keyboardNames.FIVE,
                keyboardNames.T,
                keyboardNames.G,
                keyboardNames.B,
                keyboardNames.SPACE,
                keyboardNames.LEFT_ALT,
                keyboardNames.LEFT_WINDOWS];
           

            foreach (keyboardNames keyboardName in game_board)
            {
                LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(keyboardName, 0, 255, 0);
            }
        }

        public void Play()
        {
            // Tic-Tac-Toe Game ---------------------------

            // Initialize Game
            this.InitializeBoard();


            bool in_game = true;
            bool turn_to_play = false;


            List<Char> playable_keys = ['w', 's', 'x', 'e', 'd', 'c', 'r', 'f', 'v'];
            List<List<Char>> winnable_conditions = new List<List<Char>>([
                ['w', 's', 'x'],
                ['w', 'e', 'r'],
                ['w', 'd', 'v'],
                ['e', 'd', 'c'],
                ['r', 'f', 'v'],
                ['r', 'd', 'x'],
                ['s', 'd', 'f']]);

            List<Char> p1_plays = [];
            List<Char> p2_plays = [];


            while (in_game)
            {
                //Get key input
                char played_key = Console.ReadKey().KeyChar.ToString().ToLower()[0];
                //Check if its a valid Key
                if (!playable_keys.Contains(played_key))
                {
                    Console.WriteLine("Please enter a valid key");
                    continue;
                }
                if (p1_plays.Contains(played_key))
                {
                    Console.WriteLine("Please enter a valid key");
                    continue;
                }
                if (p2_plays.Contains(played_key))
                {
                    Console.WriteLine("Please enter a valid key");
                    continue;
                }
                if (!turn_to_play)
                {
                    p1_plays.Add(played_key);
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(color_keys_dic.GetValueOrDefault(played_key), 255, 0, 0);
                }
                else
                {
                    p2_plays.Add(played_key);
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(color_keys_dic.GetValueOrDefault(played_key), 0, 0, 255);
                }


                foreach (List<Char> play in winnable_conditions)
                {

                    if (!turn_to_play)
                    {
                        var a = play.Intersect(p1_plays).ToList();
                        if (a.Count >= 3)
                        {
                            Console.WriteLine("Winner p1");
                            in_game = false;
                            continue;
                        }
                    }
                    else
                    {
                        var a = play.Intersect(p2_plays).ToList();
                        if (a.Count >= 3)
                        {
                            Console.WriteLine("Winner p2");
                            in_game = false;
                            continue;
                        }
                    }

                }

                turn_to_play = !turn_to_play;
            }
        }

    }
}
