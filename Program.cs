using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num, num_1, first;
            string name;
            Console.WriteLine("Введите первое число");

            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите наименование + - * /");
            name = Convert.ToString(Console.ReadLine());

            if (name == "+")
            {
                first = num + num_1;
                Console.WriteLine(first);
            }
            if (name == "-")
            {
                first = num - num_1;
                Console.WriteLine(first);
            }
            if (name == "*")
            {
                first = num * num_1;
                Console.WriteLine(first);
            }
            if (name == "/")
            {
                first = num / num_1;
                Console.WriteLine(first);
            }
            Console.ReadKey();
        }
    }
}
