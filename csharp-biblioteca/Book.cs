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
        public Book(string Title, string Year, string Type, string Position, string Author, int Pages) : base(Title, Year, Type, Position, Author)
        {
            this.pages = Pages;
            
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($@"                                 -Pages: {this.pages}");
        }
    }
}
