using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using ClassLibrary1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace OOP_ass01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01:
            #region Q01:
            //Explain with code example how class and struct behave differently 
            Class1 c1 = new Class1();
            c1.id = 1;
            Class1 c2 = c1;
            c2.id = 2;
            Console.WriteLine(c1.id);// will print '2' because class is a refrence type

            Struct1 s1 = new Struct1();
            s1.id = 1;
            Struct1 s2 = s1;
            s2.id = 2;
            Console.WriteLine(s1.id); // will print '1' because struct is a value type
            #endregion
            #region Q02:
            //Explain the difference between public and private access modifiers with an example. 
            // private can only access in the class 
            // public can use at anywhere 
            Class1 c3 = new Class1();
            // c3.password can not be access here as it is a private field 
            #endregion
            #region Q03:
            //Describe the steps to create and use a class library in Visual Studio.
            /*  
                1.Create new project → choose Class Library.
                2.Add reference to the class library.
                3.Use the classes in the new project*/
            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();

            #endregion
            #region Q04:
            /*
            Reuse code in many projects.
            Organize code better.
            */

            #endregion
            #endregion

            #region Part02:
            // 1.Each ticket has a type that can only be one of: Standard, VIP, or IMAX. How would you represent this? => enum
            //2.You need a type to represent a seat location (Row as a char like 'A', 'B', and Number as an int). Should this be a class or a struct? Create it. => struck 
            Console.WriteLine("Enter movie name : ");
            string movieName = Console.ReadLine();
            Console.WriteLine("Enter ticket type (0 = Standard , 1 = VIP , 2 = IMAX) ");
            int type = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seat Row (A, B, C...):");
            char row = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seat Number: ");
            int number = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());
            SeatNumber seat1 = new SeatNumber(row,number);
            Ticket ticket = new Ticket(movieName,(TicketType)type,seat1,price);
            ticket.discountAmount = discount;
            ticket.PrintTicket();

            #endregion
        }
    }
}
