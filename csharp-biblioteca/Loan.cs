using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Loan
    {
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Document document { get; set; }

        public User user { get; set; }
        public Loan(DateTime startDate, DateTime endDate, Document document, User user)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.document = document;
            this.user = user;
        }
    }
}
