using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {

        public int pages { get; private set; }
        public Book(int Pages, string Title, int Year, string Sector, string Position, string Author) : base(Title, Year, Sector, Position, Author)
        {
            this.pages = Pages;
        }
    }
}
