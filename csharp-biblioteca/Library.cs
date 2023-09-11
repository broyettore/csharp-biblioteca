using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<User> Users { get; set; }
        public List<Document> Documents {  get; set; }
        public List<Loan> Loans { get; set; }

        public Library()
        {
            Documents = new List<Document>();
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        public void AddDocs(Document document)
        {
            Documents.Add(document);
        }

        public void AddUsers(User user)
        {
            Users.Add(user);
        }   
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

        //public void RegisterLoan(Loan loan)
        //{
        //    Users.Add(loan);
        //}

        public List<Loan> SearchLoansByUser(string name, string surname)
        {
            var findUserLoan = Loans.FindAll(loan => loan.Name.ToLower() == name.ToLower() && loan.Surname.ToLower() == surname.ToLower());

            if (findUserLoan.Count > 0)
            {
                return findUserLoan;
            }
            else
            {
                return new List<Loan>();
            }
        }

        public List<Document> SearchDocumentsByCode(string code)
        {
            var findDocCode = Documents.FindAll(doc => doc.Code.Contains(code, StringComparison.OrdinalIgnoreCase));

            if(findDocCode.Count > 0) 
            {  
                return findDocCode; 
            } else 
            { 
                return new List<Document>(); 
            }
        }

        public List<Document> SearchDocumentsByTitle(string title)
        {
            var findDoc = Documents.FindAll(doc => doc.Title.Contains(title, StringComparison.OrdinalIgnoreCase));

            if (findDoc.Count > 0)
            {
                return findDoc;
            }
            else
            {
                return new List<Document>();
            }
        }



    }
}
