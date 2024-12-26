using Microsoft.VisualBasic;
using System;
namespace oopConcepts
{
    public class Program
    {
        public static void Main()
        {
            const string Msg = "Your tiket number is: {0} and the price is: {1}";
            ChristmasLotery lot = new ChristmasLotery(2343212,400000);
            Console.WriteLine(Msg, lot.Number, lot.Price);
            lot.Winner();
        }
    }
}
