namespace Task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m]. Заполнение
        случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания нового массива преобразование текущего
        по следующему правилу:
        • Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        • Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом */
        static void Main(string[] args)
        {
            int n, m;
            Random rnd = new Random();
            Console.WriteLine("Введите количество строк массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.WriteLine("Введите количество столбцов массива");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Ошибка ввода");
            }
            int[,] cube = new int[n, m];
            Console.WriteLine("Текущий массив");

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = rnd.Next(-99,100);
                    Console.Write(cube[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------\nПреобразованный массив");
            for (int i = 0; i < cube.GetLength(0); i++)
            {
              for(int j = 0;j < cube.GetLength(1); j++) 
              { 
                    if(cube[i,j] < 0) 
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(-cube[i,j]);
                    }
                    else if (cube[i,j] == 0) 
                    {
                    Console.BackgroundColor=ConsoleColor.Red;
                        cube[i,j] = 1;
                        Console.Write(cube[i,j]);
                    }
                    else
                    {
                        Console.Write(cube[i,j]);
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
              }
                Console.WriteLine();

            }

        }
    }
}
