using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter H: ");
            float hour = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter M: ");
            float minute = Convert.ToSingle(Console.ReadLine());
            if (hour == 0.00 && minute == 0.00)
            {
                Console.WriteLine("Error");
            }
            else
            {
                float angle = (minute * 6) - (hour * 30) - (minute / 2);
                if (angle < 0)
                {
                    angle = (360 + angle);
                }
                else if (angle > 180)
                {
                    angle = (360 - angle);
                }
                Console.WriteLine("{0:0.000}", angle);
            }

            Console.ReadLine();
        }
    }
}
