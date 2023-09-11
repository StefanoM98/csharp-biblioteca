using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {   
        public string name { get; private set; }

        public string surname { get; private set; }

        public string password { get; private set; }
        public string email { get; private set; }
        public string phone { get; private set; }
        
        public User(string Name, string Surname, string Password, string Email, string Phone) 
        {
    
            this.name = Name;
            this.surname = Surname;
            this.password = Password;
            this.email = Email;
            this.phone = Phone;

        }

        public void PrintUser()
        {
            Console.WriteLine($"Ciao {this.name} {this.surname}");

        }
    }
}
