using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace _2048
{
    public static class PlayersResultsStorage
    {

        public static List<Player> players;     
        static string fileName = "results.json";

        public static void SaveResults(Player player)
        {

            if (File.Exists(fileName))
            {
                players = JsonConvert.DeserializeObject<List<Player>>(FileProvider.GetValue(fileName));
            }
            else
            {
                players = new List<Player>();
            }
            
            players.Add(player);

            var jsonData = JsonConvert.SerializeObject(players);
            FileProvider.SaveToFile(fileName, jsonData);

        }

        public static List<Player> GetValue()
        {
            
            var players = JsonConvert.DeserializeObject<List<Player>>(FileProvider.GetValue(fileName));
            return players;
        }
        

    }
}
