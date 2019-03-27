using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voskov_Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Сколько раз, хотите поиграть в сапёра? ");
            int CountPlay = int.Parse(Console.ReadLine());
            for (int count = 0; count < CountPlay; ++count)
            {
                Console.Write("Введите высоту сетки: ");
                int heigth_grid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ширину сетки: ");
                int width_grid = Convert.ToInt32(Console.ReadLine());

                char[,] Size = new char[heigth_grid, width_grid];

                int FieldNumber = 0;

                for (int row = 0; row < heigth_grid; row++)
                {
                    string enterString = Console.ReadLine();
                    string[] massiveString = enterString.Split(new Char[] { ' ' });
                    for (int column = 0; column < massiveString.Length; column++)
                    {
                        Size[row, column] = char.Parse(massiveString[column]);
                    }
                }

                for (int i = 0; i < heigth_grid; ++i)
                {
                    for (int j = 0; j < width_grid; ++j)
                    {
                        if (Size[i, j] == '*')
                        {
                            continue;
                        }
                        else
                        {
                            var temp = 0;

                            if (i + 1 < heigth_grid && Size[i + 1, j] == '*')
                                ++temp;
                            if (i + 1 < heigth_grid && j + 1 < width_grid && Size[i + 1, j + 1] == '*')
                                ++temp;
                            if (j + 1 < width_grid && Size[i, j + 1] == '*')
                                ++temp;
                            if (i - 1 >= 0 && j + 1 < width_grid && Size[i - 1, j + 1] == '*')
                                ++temp;
                            if (i - 1 >= 0 && Size[i - 1, j] == '*')
                                ++temp;
                            if (i - 1 >= 0 && j - 1 >= 0 && Size[i - 1, j - 1] == '*')
                                ++temp;
                            if (j - 1 >= 0 && Size[i, j - 1] == '*')
                                ++temp;
                            if (i + 1 < heigth_grid && j - 1 >= 0 && Size[i + 1, j - 1] == '*')
                                ++temp;

                            char c = Char.Parse(temp.ToString());
                            Size[i, j] = c;
                        }
                    }

                }
                Console.WriteLine("Field#" + (count + 1));
                for (int i = 0; i < heigth_grid; i++)
                {
                    for (int j = 0; j < width_grid; j++)
                    {
                        Console.Write(Size[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
