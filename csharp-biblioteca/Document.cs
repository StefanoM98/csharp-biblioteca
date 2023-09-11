using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    {
        public string identificationCode { get; private set; }
        public string title { get; private set; }
        public int year { get; private set; }
        public string sector { get; private set; }
        public string position { get; set; }
        public string author { get; private set; }  


        public Document(string Title, int Year, string Sector, string Position, string Author)
        {
            Random rndcode = new Random();
            this.identificationCode = title + rndcode.Next(0, 9999);
            this.title = title;
            this.year = year;
            this.sector = sector;
            this.position = position;
            this.author = author;
        }

    }
}
