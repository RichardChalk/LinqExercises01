using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using CsvHelper;

namespace Cms20LinqOchAnnat
{
    class Program
    {
        static void Main(string[] args)
        {
            // /////////////////////////////////////////////////////////////////////
            var players = ReadAllFromFile();
            Console.WriteLine("All players in file ==========================");
            foreach (var p in players)
            {
                Console.WriteLine(p.Name);
            }

            // /////////////////////////////////////////////////////////////////////
            // 1: Scored at least 30 goals using 'Where'
            var over30Goals = players
                .xxxxx(x => x.xxxxx > 30)
                .ToList();

            // 2: Print to console all players in 'over30Goals'
            Console.WriteLine("Names of all players who scored at least 30 goals ==========================");
            foreach (var player in xxxxxxxxxx)
            {
                Console.WriteLine(xxxxxx.xxxx);
            }

            // 3: Print to console number of players in 'over30Goals'
            Console.WriteLine("Total number of players who scored at least 30 goals ==========================");
            Console.WriteLine(over30Goals.xxxxx());

            // 4: Scored at least 30 goals using 'Count'
            var over30GoalsLinq = players.xxxxx(p => p.xxxxx > xx);

            // /////////////////////////////////////////////////////////////////////
            // SQL
            // Select all players from team EDM
            // SELECT * Player WHERE Team='EDM' ORDER BY Name DESC

            // LINQ
            Console.WriteLine("Choose team");
            string team = Console.xxxxxxxx();

            // 5. Select all players from Team (chosen by user) - To list example 
            var myList = xxxxxxx.xxxxx(p => p.Team == xxxx).OrderByDescending(p => p.Name).ToList();

            // 6. Select all players from Team (chosen by user) - Writing player Name to console in a FOREACH loop
            foreach (var p in xxxxxxx.Where(p => p.xxxx == team).OrderByDescending(p => p.Name))
            {
                Console.WriteLine($"Chosen by user: {x.Name}");
            }
            Console.WriteLine("=============================================");

            // /////////////////////////////////////////////////////////////////////
            // 7. Select all 'ints' < 100 and print to console (FOREACH loop)
            var allaSiffror = new[] { 11, 4, 123, 56, 778, 12345 };
            foreach (var i in allaSiffror.xxxxx(t => t x xxx))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("=============================================");

            // /////////////////////////////////////////////////////////////////////
            // 8. Minsta number? 
            var minsta = allaSiffror.xxx();

            // 9. Average number? 
            xxxxxx avg = allaSiffror.xxxxxxx();

            // /////////////////////////////////////////////////////////////////////
            // 10a. Find the first player named ... (NOT a list! Only one record returned)
            // What happens if Mika isn't in the list?
            var mika = players.xxxxx(p => p.Name == "Mika Zibanejad");

            // 10b. Increase Mikas Goals by 2
            mika.xxxxx = mika.Goals x x;

            // /////////////////////////////////////////////////////////////////////
            // 11a. Find the first player named ... (NOT a list! Only one record returned)
            // What would happen if Mika wasn't in the list?
            var mika2 = players.xxxxxxxxxxxxxx(p => p.xxxx == "Mika Zibanejad");

            // 11b. Write to Console if Mika doesn't exist in list
            if (mika2 == xxxx)
            {
                Console.WriteLine("Mika finns inte i listan!!");
            }

            // /////////////////////////////////////////////////////////////////////
            // 12. Find players where Name begins with P and Team = EDM
            // Write player Name to console

            foreach (var playerP in players.Where(p => p.Name.xxxxxxxxxx("R") && p.Team == xxxxx))
            {
                Console.WriteLine($"Name starts with R and plays for EDM: {playerP.Name}");
            }
            Console.WriteLine("=============================================");

            // /////////////////////////////////////////////////////////////////////
            // 13. Sort and print player name to console
            Console.WriteLine("Players sorted by Name ============================");
            foreach (var player in xxxxxxx.xxxxxxx(p => p.Name))
            {
                Console.WriteLine(player.Name);
            }
            Console.WriteLine("=============================================");

            // /////////////////////////////////////////////////////////////////////
            // 14. Lets call a method that will return a single player object with the name we choose
            var playerMika = FindPlayerByName(xxxxxxx, "Mika Zibanejad");
            Console.WriteLine(playerMika.Name);
            Console.WriteLine("=============================================");

            // /////////////////////////////////////////////////////////////////////
            // 15. Lets call a method that will return a boolean if player has Position Forward
            var playersPosition = IsForward(xxxxxxxxxx);
            Console.WriteLine($"Player is forward: {xxxxxxxxxxxxxxx}");
            Console.WriteLine("=============================================");
        }

        // /////////////////////////////////////////////////////////////////////
        // Methods
        static Player FindPlayerByName(List<Player> all, string name)
        {
            foreach (var p in all)
                if (p.Name == xxxx)
                    return p;
            return null;
        }

        static xxxx IsForward(Player p)
        {
            return p.Position == "F";
        }

        private static List<Player> ReadAllFromFile()
        {
            using (var reader = new StreamReader(@"..\..\..\Summary.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Player>().ToList();
                return records;
            }
        }
    }
}
