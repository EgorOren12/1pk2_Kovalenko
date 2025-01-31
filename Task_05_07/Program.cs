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
            Console.Clear();
            int[,] cube = new int[n, n];
            int[] numbers = new int[5];
            Random rnd = new Random();

            for (int i = 0; i < cube.GetLength(0); i++) //задание начального массива
            {
            for (int j = 0; j < cube.GetLength(1); j++) 
                {
                    cube[i, j] = rnd.Next(10, 100);
                }
            }

            mini = cube[0, 0];//нахождение мин
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
            for (int i = 0;i < cube.GetLength(0); i++) // умножение массива на мин
                {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = cube[i, j] * mini;
                }   
                }

            for (int i = 0; i < n; i++) //нахождение 5 макс чисел
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
            Console.WriteLine("Вывод массива с выделеными цветами"); //вывод массива
            for(int i = 0;i< cube.GetLength(0); i++)
            {
                for(int j = 0; j< cube.GetLength(1); j++)
                {
                    bool b = false;
                    for (int k =0; k< numbers.Length; k++)
                    {
                        if (cube[i, j] == numbers[k])
                        {
                            b = true;
                            break;
                        }
                    }
                    if (b)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(cube[i,j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
