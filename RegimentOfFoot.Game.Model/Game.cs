using System;
using System.Xml;

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
            var saver = new XmlDocument();

        }

        public static Game LoadGame(string filename)
        {
            var loader = new XmlDocument();
            loader.Load(filename);

            Game game = new Game();
            XmlNode gameName = loader.GetElementsByTagName("GameName")?.Item(0);
            if (gameName == null)
                throw new XmlException("XML doesn't follow correct form");

            game.Name = gameName.InnerText;

        }
    }
}

