using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontWorkApp
{
    class ArticleClass
    {
        
        public int Index { get; set; }
        public string ArticleName { get; set; }
        public string ArticleText { get; set; }
        public string ArticleComment { get; set; }


        public void Comment()
        {
            Console.WriteLine("Write yor comment...");
            ArticleComment = Console.ReadLine();
            DateTime CommTime = DateTime.Now;
            Console.WriteLine(ArticleComment +" "+CommTime);
            ArticleComment = ArticleComment + " " + CommTime;
        }

    }
}
