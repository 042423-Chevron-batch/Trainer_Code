using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RpsGame1
{
    public class DocumentGames
    {
        public static bool RecordMyGame(Game game)
        {
            if (!File.Exists("GameStorage.txt"))
            {
                List<Game> gameAsList = new List<Game>();
                gameAsList!.Add(game);// '!' means that I know that the variable my be null. I want to DEREFERENCE it anyway
                string gameSerialized = JsonSerializer.Serialize(gameAsList);
                // write the serialized list of games ot the file.
                File.WriteAllText("GameStorage.txt", gameSerialized);
            }
            else
            {
                // read from the file into ta string
                string gameText = File.ReadAllText("GameStorage.txt");
                // convert the game into a list
                List<Game>? gameList = JsonSerializer.Deserialize<List<Game>>(gameText);

                // add the current game to the List<Game>
                gameList!.Add(game);// '!' means that I know that the variable my be null. I want to DEREFERENCE it anyway

                // serialize the List<Game> as Json
                string gameSerialized = JsonSerializer.Serialize(gameList);

                // write the serialized list of games to the file.
                File.WriteAllText("GameStorage.txt", gameSerialized);
            }
            return true;
        }
    }
}