using System;

namespace OOP_lab_2_6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Розмiри матрицi: ");

            string str = Console.ReadLine();

            string[] size = str.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int[][] array = new int[int.Parse(size[1])][];

            var random = new Random();

            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = new int[int.Parse(size[0])];

                for (int j = 0; j < array[i].Length; ++j)
                {
                    array[i][j] = random.Next(-100, 100);
                }
            }

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    Console.Write("{0, -5}", array[i][j]);
                }

                Console.WriteLine();
            }

            int max = array[0][0];
            int min = array[0][0];
            int minCount = 0;
            int maxCount = 0;

            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    if (max == array[i][j])
                    {
                        ++maxCount;
                    }

                    if (min == array[i][j])
                    {
                        ++minCount;
                    }

                    if (max < array[i][j])
                    {
                        max = array[i][j];

                        maxCount = 1;
                    }

                    if (min > array[i][j])
                    {
                        min = array[i][j];

                        minCount = 1;
                    }
                }
            }

            Console.WriteLine("Mаксимальний елемент: {0}", max);
            Console.WriteLine("Kiлькiсть входжень максимального елементa: {0}", maxCount);
            Console.WriteLine("Miнiмальний елемент: {0}", min);
            Console.WriteLine("Kiлькiсть входжень мiнiмального елементa: {0}", minCount);
        }
    }
}
