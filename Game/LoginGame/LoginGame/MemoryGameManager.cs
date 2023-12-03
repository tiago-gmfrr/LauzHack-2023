using LedCSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
    internal class MemoryGameManager
    {

        private static readonly HttpClient client = new HttpClient();

        public MemoryGameManager() { }

        public void Play()
        {
            List<char> played_keys = new List<char>();
            Random rnd = new Random();

          //2  played_keys.Add('y');
            for (int i = 0; i < 5; i++)
            {
               played_keys.Add(Common.GetKeys().ElementAt(rnd.Next(24)).Key);
            }

            bool in_game = true;

            bool waiting = false;

            while(in_game)
            {
                // Attendre la liste renvoyée par le serveur
                /* while(waiting)
                 {

                 }*/
                
                //Show where to touch
                foreach (char key in played_keys) {
                    Animations.GlowUp(Color.FromArgb(0, 0, 100), Common.GetKeys().GetValueOrDefault(key));
                    //LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(Common.GetKeys().GetValueOrDefault(key), 0, 0, 100);
                    
                    //LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(Common.GetKeys().GetValueOrDefault(key), 0, 0, 0);
                    Animations.GlowDown(Color.FromArgb(0, 0, 100), Common.GetKeys().GetValueOrDefault(key));
                }
                
                //Play logic
                foreach(char key in played_keys)
                {
                    char played_key = Console.ReadKey().KeyChar.ToString().ToLower()[0];

                    if(played_key != key)
                    {
                        Animations.Wave(Color.Red, Animations.Direction.Down);
                        in_game = false;
                        break;
                        // Send winner information
                    } else
                    {
                        LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(Common.GetKeys().GetValueOrDefault(key), 0, 100, 0);
                    }
                    Thread.Sleep(50);
                }
                ///////
                if (!in_game)
                    break;
                ///////
                Animations.Wave(Color.Green, Animations.Direction.Down);


                // Show all keys inserted
                foreach (char key in played_keys)
                {
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(Common.GetKeys().GetValueOrDefault(key), 0, 255, 0);
                }

                bool added_succesfuly = false;
                while (!added_succesfuly)
                {
                   char played_key_add = Console.ReadKey().KeyChar.ToString().ToLower()[0];

                    if (played_keys.Contains(played_key_add) ) {
                        Console.WriteLine("Already in list");
                        continue;
                    }

                    played_keys.Add(played_key_add);
                    added_succesfuly = true;
                    LogitechGSDK.LogiLedSetLightingForKeyWithKeyName(Common.GetKeys().GetValueOrDefault(played_key_add), 0, 255, 0);


                }

                Animations.ClearKeyboard(Color.Black, Animations.Direction.Right);

                Animations.Wave(Color.Green, Animations.Direction.Up);

                // Send List to other player
                waiting = true;

                
            }
            
        }

    }

}
