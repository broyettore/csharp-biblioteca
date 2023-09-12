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
        public Dictionary<string, Document> Documents {  get; set; }
        public List<Loan> Loans { get; set; }

        public Library()
        {
            Documents = new Dictionary<string, Document>();
            Users = new List<User>();
            Loans = new List<Loan>();
        }

        public void AddDocs(Document document)
        {
            Documents.Add(document.Code, document);
        }

        public void AddUsers(User user)
        {
            Users.Add(user);
        }   
        public void AddLoan(Loan loan)
        {
            Loans.Add(loan);
        }

       public void RegisterLoan(User user, Document document, DateTime startDate, DateTime endDate)
        {
            if(!Users.Contains(user))
            {
                Console.WriteLine("User not registered in database");
                return;
            } 
            
            if(!Documents.ContainsKey(document.Code))
            {
                Console.WriteLine("Document not available");
                return;
            }

            foreach (var key in Loans)
            {
                if(key.Document == document && key.DueDate >= key.StartDate)
                {
                    Console.WriteLine("Document has already been loaned");
                    return;
                }
            }

            var loan = new Loan(user, document, startDate, endDate);
            Loans.Add(loan);

            Console.WriteLine("Loan registered successfully");

        }

        public List<Loan> SearchLoansByUser(string name, string surname)
        {
            var findUserLoan = Loans.FindAll(loan => loan.User.Name.ToLower() == name.ToLower() && loan.User.Surname.ToLower() == surname.ToLower());
            return findUserLoan;
            
        }

        public Document SearchDocumentsByCode(string code)
        {
            var findDocCode = Documents[code];
            return findDocCode; 
           
        }

        public List<Document> SearchDocumentsByTitle(string title)
        {
            List<Document> retrievedDocuments = new List<Document>();

            var listDocument = Documents.Values;

            foreach (var doc in listDocument)
            {
                if (doc.Title == title)
                {
                    retrievedDocuments.Add(doc);
                }
            }

            return retrievedDocuments;

        }

    }
}
