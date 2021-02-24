using System;
using System.Linq;

namespace Articles2
{
    public class Articles
    {
        public override string ToString()
        {
            return $"{title} - content: Johnny ";
        }
    }
    
    class Articles2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] articleData = new string[n];


            for (int i = 0; i < n; i++)
            {
                articleData[i] = Console.ReadLine();
            }

            string criteria = Console.ReadLine().ToLower();

            if (criteria== "title")
            {
                articleData = articleData.OrderBy(x => x == "title").ToArray();
            }
            else if (criteria == "content")
            {
                articleData = articleData.OrderBy(x => x == "content").ToArray();
            }
            else if (criteria == "author")
            {
                articleData = articleData.OrderBy(x => x == "author").ToArray();
            }
        }
    }
}
