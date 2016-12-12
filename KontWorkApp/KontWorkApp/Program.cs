using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontWorkApp
{
    class Program
    {


        static void Main(string[] args)
        {
            
            ArticleClass[] ArtCollection = new ArticleClass[]
            {
               new ArticleClass() {Index = 1, ArticleName = "My first Article", ArticleText = "My 11111111111111111111111111 1111111111111111111 111111111111", ArticleComment = null},
               new ArticleClass() {Index = 2, ArticleName = "My second Article", ArticleText = "My 2222222222222222 22222222222222222222222222222 2222222222222222", ArticleComment = null},
               new ArticleClass() {Index = 3, ArticleName = "My third Article", ArticleText = "My 333333333333333333 3333333333333333333333333333333333 333333", ArticleComment = null},
               new ArticleClass() {Index = 4, ArticleName = "My fourth Article", ArticleText = "My 4444444444444444444444444444444444444444444444444444444", ArticleComment = null},
              new ArticleClass() {Index = 5, ArticleName = "My fifth Article", ArticleText = "My 55555555555555555555555555555555555555555555555555555555555555555555", ArticleComment = null},
            };

            Console.Write("Choose article, write number of Article index(1-5): ");
            int selectInd = int.Parse(Console.ReadLine());

            for (int i = 0; i < ArtCollection.Length; i++)
            {
                if (selectInd == ArtCollection[i].Index)
                {
                    Console.WriteLine(ArtCollection[i].Index + " " + ArtCollection[i].ArticleName + " " + ArtCollection[i].ArticleText);
                    Console.WriteLine("Do you want to comment this article? Tab 1 (if YES) or 2 (if NO)...");
                    int number = int.Parse(Console.ReadLine());
                    switch (number)
                    {
                        case 1:
                            {
                                ArtCollection[i].Comment();
                                Console.WriteLine("Refresh info:");
                                Console.WriteLine(ArtCollection[i].Index + " " + ArtCollection[i].ArticleName + " " + ArtCollection[i].ArticleText+ " " + ArtCollection[i].ArticleComment);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Okay... You know nothing John Snow");
                                break;
                            }
                    }
                }
            }
            


            Console.ReadKey();
        }
    }
}
