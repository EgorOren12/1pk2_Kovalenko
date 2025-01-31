namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица Z-матрицей
        (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали. Если не выполняется, то
        вывести сообщение что данная матрица не является Z-матрицей*/
        static void Main(string[] args)
        {
            //(i == n – j – 1).
            int n;
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.Clear();
            Random rnd = new Random();
            int[,] cube = new int[n, n];
            for (int i = 0; i < cube.GetLength(0); i++) //задание начального массива
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = rnd.Next(0, 2);
                }
            }
            for(int j = 0;j < cube.GetLength(1); j++) 
                {
                if (i != j & cube[i,j] !=0)
                        b = false;
                }
            }


        }
    }
}
