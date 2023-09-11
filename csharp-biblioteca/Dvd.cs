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
        public Dvd(double Duration, string Title, int Year, string Sector, string Position, string Author) : base(Title, Year, Sector, Position, Author)
        {
            this.duration = Duration;
        }


    }
}
