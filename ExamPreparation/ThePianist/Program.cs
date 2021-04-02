using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        class PianoPiece
        {
            public string Name { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }

            public PianoPiece(string name, string composer, string key)
            {
                this.Name = name;
                this.Composer = composer;
                this.Key = key;
            }

            public PianoPiece()
            {

            }

        }
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<PianoPiece> pieces = new List<PianoPiece>(count);

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split('|');

                PianoPiece pianoPiece = new PianoPiece();
                pianoPiece.Name = input[0];
                pianoPiece.Composer = input[1];
                pianoPiece.Key = input[2];

                pieces.Add(pianoPiece);
            }

            string commandInput = Console.ReadLine();

            while (commandInput != "Stop")
            {
                string command = commandInput.Split('|')[0];
                string piece = commandInput.Split('|')[1];

                switch (command)
                {
                    case "Add":
                        string composer = commandInput.Split('|')[2];
                        string key = commandInput.Split('|')[3];

                        if (PieceExists(piece, pieces))
                        {
                            Console.WriteLine($"{piece} is already in " +
                                $"the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} by {composer} in {key} " +
                                $"added to the collection!");

                            pieces.Add(new PianoPiece(piece, composer, key));
                        }
                        break;

                    case "Remove":
                        if (PieceExists(piece, pieces))
                        {
                            pieces = pieces.Where(x => x.Name != piece).ToList();
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not " +
                                $"exist in the collection.");
                        }
                        break;

                    case "ChangeKey":
                        string newKey = commandInput.Split('|')[2];

                        if (PieceExists(piece, pieces))
                        {
                            foreach (var item in pieces)
                            {
                                if (item.Name == piece)
                                {
                                    item.Key = newKey;
                                    Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist" +
                                $" in the collection.");
                        }
                        break;

                }
                commandInput = Console.ReadLine();
            }

            foreach (var song in pieces.OrderBy(x=>x.Name).ThenBy(x=>x.Composer))
            {
                Console.WriteLine($"{song.Name} -> Composer: {song.Composer}," +
                    $" Key: {song.Key}");
            }
        }

        private static bool PieceExists(string piece, List<PianoPiece> pieces)
        {
            bool exists = false;

            foreach (var element in pieces)
            {
                if (element.Name == piece)
                {
                    exists = true;
                    return exists;
                }
            }

            return exists;
        }
    }
}


