using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginGame
{
    internal class MemoryGameManager
    {
        public MemoryGameManager() { }

        public void Play()
        {
            List<char> played_keys = new List<char>();

            bool in_game = true;

            while(in_game)
            {


                foreach(char key in played_keys)
                {
                    char played_key = Console.ReadKey().KeyChar.ToString().ToLower()[0];
                }



               // char played_key = Console.ReadKey().KeyChar.ToString().ToLower()[0];

               /* if (played_keys.Contains() ) {
                    Console.WriteLine("Already in list");
                    continue;
                }*/

                //played_keys.Add(played_key);

                // Send List to other player
                
            }
            
        }

    }

}
