using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4
{
    class VendingMachine
    {       
        public bool Restocked { get; set; }
        public bool Serviced { get; set; }
        public bool Emptied { get; set; }
        public int[] Coins { get; set; } = new int[4];
        public List<Article> articles { get; set; } = new List<Article>();

        public void FillMachine(string name, string type, int articleNumber, int price)
        {
            Article article = new Article()
            {
                Name = name,
                Type = type,
                ArticleNumber = articleNumber,
                Price = price,
                Amount = 5
            };

            articles.Add(article);
        }
    }
}
