using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_2DArrays
{
    class Program
    {
        static void Main(String[] args)
        {
            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }




            int[] sum = new int[16];
            int cnt = 0;
            int col = 0;
            int row = 0;

            while (row <= 3)
            {
                while (col <= 3)
                {
                    for (int j = col; j < col + 3; j++)
                    {
                        sum[cnt] += arr[row][j];
                    }

                    sum[cnt] += arr[row + 1][col + 1];

                    for (int j = col; j < col + 3; j++)
                    {
                        sum[cnt] += arr[row + 2][j];
                    }

                    col++;
                    cnt++;
                }
                row++;
                col = 0;
            }
                                     
            Console.WriteLine($"{sum.Max()}");
            
        }
    }
}