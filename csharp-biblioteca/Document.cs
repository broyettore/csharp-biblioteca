using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Field { get; set; }
        public int Shelf { get; set; }
        public string Author { get; set; }

        public Document(string title, int year, string field, int shelf, string author)
        {
            Code = $"{title[0].ToString().ToUpper()}-{GenRandom()}";
            Title = title;
            Year = year;
            Field = field;
            Shelf = shelf;
            Author = author;
        }


        // Generates a random code starting with the first letter of the doc title
        public virtual int GenRandom()
        {
            // Generate a random number between 1 and 1000
            int min = 1;
            int max = 1000;

            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }
    }
}
