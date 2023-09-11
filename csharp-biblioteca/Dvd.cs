using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public double duration { get; private set; }
        public Dvd(string Title, string Year, string Type, string Position, string Author, double Duration) : base(Title, Year, Type, Position, Author)
        {
            this.duration = Duration;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($@"                                 -Duration: {this.duration}");
        }

    }
}
