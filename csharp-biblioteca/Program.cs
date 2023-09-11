namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new("Hello World", 2001, "Computer Science", 3, "Joe Kruger");
            Book book2 = new("Trading Intro", 2005, "Finance", 5, "Nathan Vegas");
            Book book3 = new("One Piece", 2000, "Shonen(Manga)", 2, "Eichiro Oda");
            Dvd dvd1 = new("Rush Hour", 2002, "Comic/Action", 12, "Michael Bravado");
            Dvd dvd2 = new("The Witcher", 2023, "Fantasy", 12, "Denis Thampton");
            Dvd dvd3 = new("The Nun", 2022, "Horror", 15, "Sara Memphis");

            User user1 = new("Luis", "Icar", "12345678", "3717892345");
            User user2 = new("Fary", "Lemon", "xP9ioTYFY", "2347890567");
            User user3 = new("Tom", "Cruise", "MiTYFGT10", "1456789087");
            User user4 = new("Hera", "Ràmon", "p3Uj89BGcf", "4563456789");
            User user5 = new("Stephen", "King", "fUnd78TJsR", "3465623478");

            Loan loan1 = new("Luis", "Icar", book2, DateTime.Now, DateTime.Now);
            Loan loan2 = new("Fary", "Lemon", book1, DateTime.Now, DateTime.Now);
            Loan loan3 = new("Tom", "Cruise", book3, DateTime.Now, DateTime.Now);
            Loan loan4 = new("Hera", "Ràmon", dvd3, DateTime.Now, DateTime.Now);
            Loan loan5 = new("Stephen", "King", dvd2, DateTime.Now, DateTime.Now);


            Library library1 = new Library();
            library1.AddUsers(user1);
            library1.AddDocs(dvd1);
            library1.AddLoan(loan1);

            foreach (var item in library1.SearchDocumentsByTitle("rush"))
            {
               Console.WriteLine($"Found: {item.Title}");
            }  

            foreach (var item in library1.SearchLoansByUser("luis", "icar"))
            {
               Console.WriteLine($"Found: {item.Name} {item.Surname}");
            }  

        }
    }
}