using Library_System.Module;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public  class LibraryContext
    {
        public List<Book> Books {  get; set; }
        public List<Member> members { get; set; }
        public List<Loan> loans { get; set; }
        public List<Reservation> reservations { get; set; }
    }
}
