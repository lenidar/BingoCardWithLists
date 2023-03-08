using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoCardWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] bingoCard = new int[5, 5];
            List<int> list = new List<int>();
            Random rnd = new Random();
            int temp = 0;

            // generating the numbers
            for (int c = 0; c < bingoCard.GetLength(1); c++)
            {
                list.Clear();
                for (int nums = 1; nums < 16; nums++)
                    list.Add(nums);

                for (int r = 0; r < bingoCard.GetLength(0); r++)
                {
                    // - generating the number based on column
                    temp = rnd.Next(0, list.Count);
                    bingoCard[r, c] = list[temp];
                    list.RemoveAt(temp);
                }
            }

            // displaying the card before being formatted
            for (int r = 0; r < bingoCard.GetLength(0); r++)
            {
                for (int c = 0; c < bingoCard.GetLength(1); c++)
                {
                    Console.Write(bingoCard[r,c] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\n");
            // display
            for (int r = 0; r < bingoCard.GetLength(0); r++)
            {
                for (int c = 0; c < bingoCard.GetLength(1); c++)
                {
                    //bingoCard[r, c] = bingoCard[r, c] + (15 * c);
                    bingoCard[r, c] += (15 * c);
                    //string f = bingoCard[r, c].ToString();
                    //while (f.Length < 3)
                    //    f = "0" + f;
                    //Console.Write(f + "\t");
                    Console.Write(bingoCard[r, c] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
