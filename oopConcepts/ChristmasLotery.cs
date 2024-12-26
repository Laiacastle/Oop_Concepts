using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConcepts
{
    public class ChristmasLotery
    {
        public int Number { get; set; }
        public int Price { get; set; }

        public ChristmasLotery(int number, int price)
        {
            Number = number;
            Price = price;
        }
        public ChristmasLotery() { }
    }
}
