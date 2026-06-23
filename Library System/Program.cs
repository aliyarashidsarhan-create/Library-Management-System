using Library_System.Module;
using Microsoft.Win32;

namespace Library_System
{
    public class Program
    {
        //system storage
        public static LibraryContext context = new LibraryContext
        {
            Books=new List<Book>(),
            Members=new List<Member>(),
            Loans=new List<Loan>(),
            Reservations=new List<Reservation>()
        };
        //----------------------------------------------
        //Register Member
        public static void RegisterMember()
        {
            Console.WriteLine("\n=== Register New Member ===");

            Console.WriteLine("Enter Member Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Member phone ");
            string phone = Console.ReadLine();

            Console.WriteLine("Enter Member Email ");
            string email = Console.ReadLine();

            int memberId = context.Members.Count + 1;


            context.Members.Add(new Member
            {
                memberId = memberId,
                memberName = name,
                memberPhone = phone,
                memberEmail = email,
                numBorrowBook = 0,
                registerDate = DateTime.Now.ToShortDateString(),
                isActive = false
            });
            Console.WriteLine($"Member register successfully .With Id:{memberId}");
        }
        //------------------------------------------
        //add book
        public static void AddBook()
        {
            Console.WriteLine("\n=== Add New Book ===");

            Console.WriteLine("Enter Book Title");
            string title = Console.ReadLine();

            Console.WriteLine("Enter auther");
            string author= Console.ReadLine();

            Console.WriteLine("Enter Total copy");
            int copies=int .Parse(Console.ReadLine());

            int bookId = context.Books.Count + 1;
            context.Books.Add(new Book
            {
              bookId = bookId,
              title=title,
              author=author,
              totalCopies=copies,
              availabelBook=copies,
              borrowCount=0,

            });
            Console.WriteLine($"Book added Sucessfully with Id:{bookId}");
            }
        //-----------------------------------------------------
        static void Main(string[] args)
        {
            bool exit=false;
            while (exit == false)
            {
                Console.WriteLine("Library Manegment System");
                Console.WriteLine("1- Register Member");//add , list(members)
                Console.WriteLine("2- Add Book");//add , list (books)
                Console.WriteLine("3- View Books");//read ,list(books)
                Console.WriteLine("4- Borrow Book");//add
                Console.WriteLine("5- Return Book");//update
                Console.WriteLine("6- Reserve Book");//add
                Console.WriteLine("7- View Active Loans");//read
                Console.WriteLine("8- View Overdue Loans");//read
                Console.WriteLine("9- Calculate Fine");//calculation
                Console.WriteLine("10- Most Borrowed Books");//read report
                Console.WriteLine("0- Exit");

                Console.WriteLine("Select Option");
                int option=int.Parse(Console.ReadLine());

                switch(option) 
                {
                    case 1: RegisterMember();break;
                    case 2: AddBook(); break;
                    case 3: break;
                    case 4:  break;
                    case 5: break;
                    case 6:  break;
                    case 7:  break;
                    case 8: break;
                    case 9: break;
                    case 10: break;
                    case 0: exit = true; break;

                    default: Console.WriteLine("Invalid option . Please try again"); break;
                }
                if(!exit)
                {
                    Console.WriteLine("\nPress any key to continue ..");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.WriteLine("GoodBy!");
        }
    }
}


