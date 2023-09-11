using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public Loan(User user,Document document,DateTime startDate,DateTime dueDate)
        {
            User = user;
            Document = document;
            StartDate = startDate;
            DueDate = dueDate;
        }
    }
}
