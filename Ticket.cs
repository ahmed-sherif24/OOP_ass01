using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_ass01
{
    public class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public SeatNumber Seat;
        private double Price;
        public double discountAmount;



        public Ticket(string name, TicketType type, SeatNumber seat , double price)
        {
            MovieName = name;
            Type = type;
            Seat = seat;
            Price = price;

        }
        public Ticket(string name)
            :this(name, TicketType.Standard,new SeatNumber('A',1), 50)
        {
            
        }


        //a.CalcTotal() — receives a taxPercent(double), calculates the total after tax and returns it.The original price must stay unchanged.
        //b.ApplyDiscount() — receives a discountAmount (double) . If discount is valid (> 0 and ≤ Price), deducts it from Price and sets discountAmount to 0 (consumed). Otherwise, the discount stays unchanged.
        //c.PrintTicket() — prints the full ticket info.

        public double CalcTotal()
        {
            double total = Price + Price * 0.14;
            return total;
        }

        public void ApplyDiscount()
        {
            if (discountAmount > 0 && discountAmount <= Price)
            {
                Price -= discountAmount;

                discountAmount = 0; 
            }
        }
        public void PrintTicket()
        {
            Console.WriteLine("============== Ticket Info ==============");

            Console.WriteLine($"Movie Name : {MovieName}");
            Console.WriteLine($"Type       : {Type}");
            Console.WriteLine($"Seat       : {Seat.Number}{Seat.Row}");
            Console.WriteLine($"Price      : {Price}");
            Console.WriteLine($"Total (14% tax) : {CalcTotal()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("============== After Discount ==============");
            ApplyDiscount();
            Console.WriteLine($"Movie Name : {MovieName}");
            Console.WriteLine($"Type       : {Type}");
            Console.WriteLine($"Seat       : {Seat.seatInfo}");
            Console.WriteLine($"Price      : {Price}");
            Console.WriteLine($"Total (14% tax) : {CalcTotal}");
        }


    }
}
