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
                //List<PianoPiece> pianoPieces = new List<PianoPiece>();
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

                PianoPiece piece = new PianoPiece()
                {
                    piece.Name = input[0],
                    piece.Composer = input[1],
                    piece.Key = input[2];
            }

            string commandInput = Console.ReadLine();

            while (commandInput != "Stop")
            {
                string command = commandInput.Split('|')[0];

                switch (command)
                {
                    case "Add":
                        if (pieces.Contains(piece))
                        {
                            Console.WriteLine($"{piece} is already in " +
                                $"the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                }
            }
            pieces.Add(piece);
        };
    }


}
}
}
