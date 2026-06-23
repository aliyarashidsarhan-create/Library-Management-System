using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Module
{
    public  class Reservation
    {
        public int reservationId {  get; set; }//system generated
        public int bookId { get; set; } // From List
        public int memberId { get; set; } // From List
         public string reservationDate { get; set; }// System Generated
        public string status { get; set; }//defult
    }
}
