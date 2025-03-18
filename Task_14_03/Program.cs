using System.Threading.Channels;

namespace Task_14_03
{
    internal class Program
    {
        /*Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал. 
         * Сделайтетак, чтобы метод работал только для неотрицательных чисел*/
        static void Main(string[] args)
        {
            long n;
            Console.WriteLine("Введите число");
            while (!long.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            if (n < 0)
                Console.WriteLine("Факториал числа определен только для положительных чисел");
            else
            Console.WriteLine($"Факториал числа {n} = {Factorial(n)}");
            static long Factorial(long a)
            {
               long factorial = 1;
               for (int i = 1; i <= a; i++)
               {
                        factorial *= i;
               }         
               return factorial;
            }
        }
    }
}
