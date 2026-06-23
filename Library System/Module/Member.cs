using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System.Module
{
    public  class Member
    {
        public int memberId {  get; set; }  //system generated
        public string memberName { get; set; }//user input
        public string memberPhone { get; set; }//user input
        public string memberEmail { get; set; }//user input
        public int numBorrowBook { get; set; }//calculate
        public string registerDate { get; set; }//system generate
        public bool isActive { get; set; }//default
    }
}
