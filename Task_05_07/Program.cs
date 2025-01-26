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
            Console.WriteLine();
            Console.WriteLine($"Минимальный элемент массива - {mini}");
        }
    }
}
