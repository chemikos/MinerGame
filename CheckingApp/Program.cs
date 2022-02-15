using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;

namespace CheckingApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            //string minerSerialized = JsonConvert.SerializeObject(miner);
            //File.WriteAllText(@"c:\jsons\miner.json", minerSerialized);

            //string deserializedMiner = File.ReadAllText(@"c:\jsons\miner.json");
            //var miner = JsonConvert.DeserializeObject<DataStructure.Miner>(deserializedMiner);




            /*
            string filePath = $@"c:\jsons\Test5 x125.json";
            string deserializedOgame = File.ReadAllText(filePath);
            var index = deserializedOgame.IndexOf("GameSpeed");
            var result = deserializedOgame.Substring(index, 20);
            Console.WriteLine("Result: " + result);
            var match = Regex.Match(result, "([0-9]+)");
            int value = int.Parse(match.Value);
            if (match.Success)
            {
                Console.WriteLine("index: " + match.Index);
                Console.WriteLine("value: " + match.Value);
            }
            else
            {
                Console.WriteLine("Nie działa");
            }
            */
            Console.WriteLine("Zmiany dla testu gita.");

        }
    }
}
