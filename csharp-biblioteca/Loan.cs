using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan : User
    {
        public Document Document { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public Loan(string name, string surname,Document document,DateTime startDate,DateTime dueDate) : base(name, surname)
        {
            Document = document;
            StartDate = startDate;
            DueDate = dueDate;
        }
    }
}
