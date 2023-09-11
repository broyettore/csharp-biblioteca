using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        public string Name {  get; set; }
        public string Surname {  get; set; }
        public string Email {  get; set; }
        public string Password {  get; set; }
        public string PhoneNumber {  get; set; }

        public User(string name, string surname, string password = null, string phoneNumber = null)
        {
            Name = name;
            Surname = surname;
            Email = GetEmail();
            Password = password;
            PhoneNumber = phoneNumber;
        }

        public string GetEmail()
        {
            return $"{this.Name}{this.Surname}@gmail.com";
        }
    }
}
