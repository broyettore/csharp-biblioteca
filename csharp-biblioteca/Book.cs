using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public int TotalPages { get; private set; }

        public Book(string title, int year, string field, int shelf, string author) : base(title, year, field, shelf, author)
        {
            TotalPages = GenRandom();
        }

        public override int GenRandom()
        {
            // Generate a random number between 80 and 1000
            int min = 80;
            int max = 1000;
            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }
    }
}
