using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // українська в консолі
            Console.WriteLine("Task 1"); Task_1();
            Console.WriteLine("\nTask 2"); Task_2();
            Console.WriteLine("\nTask 3"); Task_3();
        }

        static void Task_1()
        {
            Console.Write("Введіть натуральне число n: ");
            uint number_10 = Convert.ToUInt32(Console.ReadLine());
            uint number_10_copy = number_10;
            uint number_2 = 0;
            int i = 0;
            while (number_10 > 0)
            {
                number_2 += (number_10 % 2) * Convert.ToUInt32(Math.Pow(10, i));
                number_10 /= 2;
                ++i;
            }
            Console.WriteLine("Число в десятковій системі числення: " + number_10_copy);
            Console.WriteLine("Число в двійковій системі числення: " + number_2);
        }

        static void Task_2()
        {
            Console.Write("Введіть дійсне число x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть дійсне число y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть дійсне число z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double sqrt = Math.Sqrt(x * x + y * y);
            double z_3 = Math.Pow(z, 3) / 6;

            double a = 2 * sqrt - z_3;
            double b = 1 - sqrt;
            double c = Math.Sin(z_3) + Math.Cos(Math.PI / 4);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");

            if (a >= b && a >= c)
                Console.WriteLine($"max(a,b,c) = {a}");
            else if (b >= a && b >= c)
                Console.WriteLine($"max(a,b,c) = {b}");
            else if (c >= a && c >= b)
                Console.WriteLine($"max(a,b,c) = {c}");
        }

        static void Task_3()
        {
            int[,] A = new int[5, 6];
            Random random = new Random();

            Console.WriteLine("Матриця A розміру 5x6:");
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 6; ++j)
                {
                    A[i, j] = random.Next(10, 100);
                    Console.Write(A[i, j] + "   ");
                }
                Console.WriteLine();
            }

            int[] b = new int[5];

            for (int i = 0; i < 5; ++i)
            {
                int max_i = A[i, 0];
                for (int j = 1; j < 6; ++j)
                {
                    if (A[i, j] > max_i)
                        max_i = A[i, j];
                }
                b[i] = max_i;
            }

            Console.WriteLine("Вектор b: ");
            foreach (int i in b) Console.Write(i + "  ");
            Console.WriteLine();

            int min_b = b[0];
            int index = 0;
            for (int i = 1; i < b.Length; ++i)
            {
                if (b[i] < min_b)
                {
                    min_b = b[i];
                    index = i;
                }
            }
            Console.WriteLine($"Індекс найменшого елемента у векторі b: {index}");
            Console.WriteLine($"Порядковий номер найменшого елемента у векторі b: {index + 1}");
        }
    }
}
