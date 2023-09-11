using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document : Library
    {
        public string identificationCode { get; private set; }
        public string title { get; private set; }
        public string year { get; private set; }
        public string type { get; private set; }
        public string position { get; set; }
        public string author { get; private set; }  


        public Document(string Title, string Year, string Type, string Position, string Author) : base ()
        {
            Random rndcode = new Random();
            this.identificationCode = title + rndcode.Next(0, 9999);
            this.title = Title;
            this.year = Year;
            this.type = Type;
            this.position = Position;
            this.author = Author;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($@"Document {this.identificationCode}:
                                 -Title: {this.title}
                                 -Author: {this.author}
                                 -Release date: {this.year}
                                 -Genre: {this.type}
                                 -Position: {this.position}");
        } 

    }
}
