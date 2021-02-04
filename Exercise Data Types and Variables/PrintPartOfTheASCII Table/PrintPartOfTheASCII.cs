using System;

namespace PrintPartOfTheASCII_Table
{
    class PrintPartOfTheASCII
    {
        static void Main(string[] args)
        {
            //Find online more information about ASCII (American Standard Code for
            //Information Interchange) and write a program that prints part of the
            //ASCII table of characters at the console.  On the first line of input
            //you will receive the char index you should start with and on the
            //second line - the index of the last character you should print.
            char startIndex = (char)int.Parse(Console.ReadLine());
            char endIndex = (char)int.Parse(Console.ReadLine());

            for (char i = startIndex; i <= endIndex; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
