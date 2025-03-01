using System.Globalization;

namespace Task_06_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий значения, 
         * принимает целое число n, выводит на консоль сгенерированный 
         * массив размерности n*n.*/

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            ArrayGeneration(n);
        }
        /// <summary>
        /// производит генерацию и вывод на консоль массива
        /// </summary>
        /// <param name="n">размер массива</param>

        static void ArrayGeneration(int n)
        {
            int[,] array = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

