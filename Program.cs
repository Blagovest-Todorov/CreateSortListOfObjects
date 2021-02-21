using System;
using System.Collections.Generic;
using System.Linq;

namespace OldArticles
{
    class Article 
    {
        public  string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {

            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numbArticles = int.Parse(Console.ReadLine());  //numebr of Artiles            

            List<Article> articles = new List<Article>();

            List<Article> articlesSorted = new List<Article>(articles.Count);

            for (int i = 0; i < numbArticles; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string inTitle = inputInfo[0];
                string inContent = inputInfo[1];
                string inAuthor = inputInfo[2];

                Article article = new Article()   ///Object Initializer
                {
                    Content = inContent,
                    Author = inAuthor,
                    Title = inTitle
                };

                articles.Add(article);
            }

            string commandSort = Console.ReadLine();

            if (commandSort == "title")//sort by title
            {
                articles.Sort((x, y) => x.Title.CompareTo(y.Title));// using here LinMethod sort-
            }
            else if (commandSort == "content")  //sort by content--by resorting the existing list
            {
                articles.Sort((x, y) => x.Content.CompareTo(y.Content));
            }
            else  // sort by author // we doe not create a new list, we just sort the old one !!!
            {
                articles.Sort((x, y) => x.Author.CompareTo(y.Author));                
            }

            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
