using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Module
{
    public class Book
    {
        public int bookId {  get; set; }//system generated
        public string title { get; set; } //user input
        public string author { get; set; }//user input
        public int totalCopies { get; set; }//user input
        public int availabelBook { get; set; }//defult
        public int borrowCount { get; set; }//defult
    }
}
