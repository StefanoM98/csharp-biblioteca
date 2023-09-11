using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Library
    {
        public List<Document> Documents = new List<Document>();
        public List<User> Users = new List<User>();
        public List<Loan> Loans = new List<Loan>();

        

       /* public void AddDocumentInLibrary(Document document)
        {
            this.Documents.Add(document);
        }
        public void AddUserInLibrary(User user)
        {
            this.Users.Add(user);
        }

        public void AddLoanInLibrary(Document document, User user) 
        {
            this.Loan.Add(document, user);
        }*/

        public void AddDocumentInLibrary (Document document)
        {
            this.Documents.Add (document);
        }

        public void AddUserInLibrary (User user)
        { 
            this.Users.Add (user);
        }

        public void AddLoanInLibrary(Loan loan)
        {
            this.Loans.Add(loan);
        }

        public Document FindByTitle(string title)
        {
            foreach (Document document in Documents)
            {
                if (document.title == title)
                {
                    return document;
                }
            }
            return null;
        }
    }
}
