using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace RegimentOfFoot.Game.Model
{
    public class Game
    {
        public Game()
        {
        }

        string Name
        {
            get;
            set;
        }

        public static void SaveGame(Game game)
        {
            //Newtonsoft.Json.

        }

        public static Game LoadGame(string filename)
        {
            

        }
    }
}

