using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksimalnaPloshtadka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи ред: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Въведи колона: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(str[j]);
                }
            }

            int sumMax = int.MinValue;
            int rowMax = -1, colMax = -1;

            for (int row = 0; row < n - 1; row++)
            {
                for (int col = 0; col < m - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > sumMax)
                    {
                        sumMax = sum;
                        rowMax = row;
                        colMax = col;
                    }
                }
            }

            Console.WriteLine("Краен резултат:");
            Console.WriteLine($"{matrix[rowMax, colMax]} {matrix[rowMax, colMax+1]}");
            Console.WriteLine($"{matrix[rowMax+1,colMax]} {matrix[rowMax+1,colMax+1]}");
        }
    }
}
