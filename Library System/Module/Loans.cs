using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Module
{
    public class Loans
    {
        public int loanId {  get; set; }//system generated
        public int bookId { get; set; }//user input from List of book
        public int memberId { get; set; }//user input from List of member
        public string borrowDate { get; set; }//
        public string dueDate { get; set; }
        public string returnDate { get; set; }
        public decimal fineAmount {  get; set; }

    }
}
