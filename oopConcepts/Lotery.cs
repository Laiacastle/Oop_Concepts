using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopConcepts
{
    public class Lotery
    {
        public int Date { get; set; }
        public string? Location { get; set; }

        public virtual void Winner()
        {
            Console.WriteLine("This Tiket Is the winner");
        }
    }
}
