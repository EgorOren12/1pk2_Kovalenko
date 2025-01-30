using System.Linq.Expressions;
using System.Xml.Schema;

namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n]. Заполнение случайными
        числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы на ее
        минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве */
        static void Main(string[] args)
        {
            int n,mini;
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            int[,] cube = new int[n, n];
            int[] numbers = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < cube.GetLength(0); i++) 
            {
            for (int j = 0; j < cube.GetLength(1); j++) 
                {
                    cube[i, j] = rnd.Next(10, 100);
                    Console.Write(cube[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");
            mini = cube[0, 0];
            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    if (mini > cube[i, j])
                    {
                        mini = cube[i, j];
                    }
                }
            }
            for (int i = 0;i < cube.GetLength(0); i++)
                {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = cube[i, j] * mini;
                    Console.Write(cube[i,j]+" ");
                }
                Console.WriteLine();
                    
                }
            Console.WriteLine("--------------------------");

            for (int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    for(int k =0; k < numbers.Length; k++)
                    {
                        if (cube[i,j] > numbers[k])
                        {
                            for(int l = numbers.Length - 1; l > k; l--)
                            {
                                numbers[l] = numbers[l-1];
                            }
                            numbers[k] = cube[i,j];
                            break;
    
                        }
                    }
                }
            }
            for(int i = 0;i<


            

            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива - {mini}, ");
        }
    }
}
