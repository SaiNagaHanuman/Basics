using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Fee_Exception : ApplicationException
    {
        public Fee_Exception(string msg) : base(msg)
        {

        }
    }
    class DoctorFeeDetails
    {
        private int RegNo;
        private string Name;
        private int FeeCharged;

        public int Registration_no
        {
            get { return RegNo; }
            set { RegNo = value; }
        }
        public string doctor_name
        {
            get { return Name; }
            set { Name = value; }
        }
        public int Fees_Charged
        {
            get { return FeeCharged; }
            set { FeeCharged = value; }
        }
        public void display_doctor()
        {
            Console.WriteLine($"Registration number is :{RegNo }");
            Console.WriteLine($"Name is                :{Name}");
            Console.WriteLine($"Fee charged is         :{FeeCharged}");

        }

    }

    class RecordBooks
    {
        public string Bookname;
        public string authorname;
        public RecordBooks(string Bookname, string authorname)
        {
            this.Bookname = Bookname;
            this.authorname = authorname;
        }

        public void display_book()
        {
            Console.WriteLine($"Book Name is  : {Bookname} , author Name is: {authorname}");
        }
    }
    class Bookshelf
    {
        private RecordBooks[] booksobj = new RecordBooks[5];
        public RecordBooks this[int i]
        {
            get
            {
                return booksobj[i];
            }
            set
            {
                booksobj[i] = value;
            }

        }

    }

    class AllDetails
    {
        static void Main()
        {

            DoctorFeeDetails d = new DoctorFeeDetails();
            Console.WriteLine("Enter registration number");
            d.Registration_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter doctor name");

            d.doctor_name = Console.ReadLine();
            Console.WriteLine("Enter Fee charged");

            d.Fees_Charged = int.Parse(Console.ReadLine());
            Console.WriteLine("=====doctor details======");
            d.display_doctor();

            Bookshelf bs = new Bookshelf();
            Console.WriteLine("========Books details=========");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"enter Book {i + 1}");
                string bookname = Console.ReadLine();
                Console.WriteLine($"enter author {i + 1}");
                string authorname = Console.ReadLine();
                bs[i] = new RecordBooks(bookname, authorname);
            }

            for (int i = 0; i < 5; i++)
            {
                bs[i].display_book();
            }
            Console.ReadLine();
        }
    }
}
