using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oopConcepts
{
    public class ChildDayLotery: Lotery
    {
        public int Number { get; set; }
        public int Day { get; set; }

        public LoteryStand LoteryStand
        {
            get => default;
            set
            {
            }
        }

        public ChildDayLotery(int number, int day) 
        {
            Number = number;
            Day = day;
        }
        public ChildDayLotery() { }
    }
}