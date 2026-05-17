using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ass01
{
    public struct SeatNumber
    {
        public int Number;
        public char Row;
        public SeatNumber(char row, int number)
        {
            Row = row;
            Number = number;
        }
        public void seatInfo ()
        {
            Console.WriteLine($"{Row}{Number}");
        }
    }
}
