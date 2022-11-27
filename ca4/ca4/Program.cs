namespace ca4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Oh, hi, Mark!");
            Console.ReadKey();

            int A, B, C;

            Console.WriteLine("Введите два числа : ");
            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = A + B;
            Console.WriteLine("Сумма данных чисел:");
            Console.WriteLine(C);
            Console.ReadLine();
            if (A > B)
            {
                C = A - B;
            }
            else
            {
                C = B - A;
            }
            Console.WriteLine("Разность данных чисел:");
            Console.WriteLine(C);
            Console.ReadLine();
            C = A * B;
            Console.WriteLine("Произведение данных чисел:");
            Console.WriteLine(C);
            Console.ReadLine();
            if (A > B)
            {
                C = A / B;
            }
            else
            {
                C = B / A;
            }
            Console.WriteLine("Деление данных чисел:");
            Console.WriteLine(C);
            Console.ReadLine();
        }
    }

}