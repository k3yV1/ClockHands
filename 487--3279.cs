using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Program
    {
        public static string Test(string s)
        {
            string phrase1 = "";
            string s1 = s.ToUpper();
            char[] array = s1.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 'A' || array[i] == 'B' || array[i] == 'C')
                {
                    phrase1 = phrase1 + "2";
                }
                else if (array[i] == 'D' || array[i] == 'E' || array[i] == 'F')
                {
                    phrase1 = phrase1 + "3";
                }
                else if (array[i] == 'G' || array[i] == 'H' || array[i] == 'I')
                {
                    phrase1 = phrase1 + "4";
                }
                else if (array[i] == 'J' || array[i] == 'K' || array[i] == 'L')
                {
                    phrase1 = phrase1 + "5";
                }
                else if (array[i] == 'M' || array[i] == 'N' || array[i] == 'O')
                {
                    phrase1 = phrase1 + "6";
                }
                else if (array[i] == 'P' || array[i] == 'R' || array[i] == 'S')
                {
                    phrase1 = phrase1 + "7";
                }
                else if (array[i] == 'T' || array[i] == 'U' || array[i] == 'V')
                {
                    phrase1 = phrase1 + "8";
                }
                else if (array[i] == 'W' || array[i] == 'X' || array[i] == 'Y')
                {
                    phrase1 = phrase1 + "9";
                }
                else if (array[i] == '0')
                {
                    phrase1 = phrase1 + "0";
                }
                else if (array[i] == '1')
                {
                    phrase1 = phrase1 + "1";
                }
                else if (array[i] == '2')
                {
                    phrase1 = phrase1 + "2";
                }
                else if (array[i] == '3')
                {
                    phrase1 = phrase1 + "3";
                }
                else if (array[i] == '4')
                {
                    phrase1 = phrase1 + "4";
                }
                else if (array[i] == '5')
                {
                    phrase1 = phrase1 + "5";
                }
                else if (array[i] == '6')
                {
                    phrase1 = phrase1 + "6";
                }
                else if (array[i] == '7')
                {
                    phrase1 = phrase1 + "7";
                }
                else if (array[i] == '8')
                {
                    phrase1 = phrase1 + "8";
                }
                else if (array[i] == '9')
                {
                    phrase1 = phrase1 + "9";
                }
            }

            return phrase1;
        }

        public static string Count(ref string[] count)
        {
            var result = count.GroupBy(x => x);
            string second_result = "";
            foreach (var key in result)
            {
                if (key.Count() > 1)
                {
                    second_result += Tire(key.Key) + "(" + key.Count() + ")\n";
                }
            }
            return second_result;
        }

        public static string Tire(string tire)
        {
            string s = tire.Remove(0, 3);
            string s1 = tire.Substring(0, 3) + "-" + s;
            return s1;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input:");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] parr = new string[n];
                if (n < 100000)
                {
                    Console.WriteLine();
                    for (int count = 0; count < n; count++)
                    {
                        //Console.Write("Введите фразу: ");
                        string phrase = Console.ReadLine();
                        Test(phrase);

                        string p = Test(phrase);
                        parr[count] = p;

                    }

                    string s = Count(ref parr);

                    Console.WriteLine();
                    Console.WriteLine("Output:");

                    if (String.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("No duplicates");
                    }
                    else
                    {
                        Console.WriteLine(Count(ref parr));
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Value must be less then 100.000....Try again :( ");
                }
            }

            Console.ReadLine();
        }
    }
}