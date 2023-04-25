using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriugulnikNaPaskal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи височина: ");
            int h = int.Parse(Console.ReadLine());
            int[][] triangle = new int[h + 1][];

            for (int row = 0; row < h; row++)
            {
                triangle[row] = new int[row + 1];
            }

            triangle[0][0] = 1;

            for (int row = 0; row < h - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            for (int row = 0; row < h; row++)
            {
                for (int space = 0; space < h - row - 1; space++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col <= row; col++)
                {
                    Console.Write($"{triangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
