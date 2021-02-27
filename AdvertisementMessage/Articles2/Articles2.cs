using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    public class Article
    {
        public Article()
        {
            Title = null;
            Content = null;
            Author = null;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author} ";
        }
    }

    class Articles2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ");

                Article article = new Article();

                article.Title = articleData[0];
                article.Content = articleData[1];
                article.Author = articleData[2];

                articles.Add(article);
            }
            
            string criteria = Console.ReadLine().ToLower();

            if (criteria == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (criteria == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}
