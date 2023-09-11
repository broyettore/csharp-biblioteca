using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd(string title, int year, string field, int shelf, string author) : base(title, year, field, shelf, author)
        {
            Duration = GenRandom();
        }

        public override int GenRandom()
        {
            // Generate a random number between 80 and 1000
            int min = 60;
            int max = 181;
            int randNumber = Random.Shared.Next(min, max);

            return randNumber;
        }
    }
}
