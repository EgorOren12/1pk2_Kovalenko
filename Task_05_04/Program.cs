using System.ComponentModel.Design;

namespace Task_05_04
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
        диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
        сообщение что матрица не является диагональной.*/ 
        static void Main(string[] args)
        {
            int n;bool b = true;                              //код рабочий, но из-за условия заполнения массива(в условии не прописано как верх и них диагонали должен быть = 0)
                                                              //шанс вывести диагональ очень маленький
            Random rnd = new Random();
            Console.WriteLine("Введите длину массива");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода");
            }
            int[,] cube = new int[n, n];
            for( int i = 0; i < cube.GetLength(0);i++) 
            {
                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = rnd.Next(0, 2); //если поменять 2 на 1 то выводит диагональ 100% :)
                }
            }
            for (int i = 0; i < cube.GetLength(0); i++) 
            {
            for(int j = 0;j < cube.GetLength(1); j++) 
                {
                if (i != j & cube[i,j] !=0)
                        b = false;
                }
            }
            if (b == true)
            {

                for (int i = 0; i < cube.GetLength(0); i++)
                {
                    for (int j = 0; j < cube.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(cube[i, j]);
                        }
                        else
                        { Console.Write(cube[i, j]); }
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }

                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Матрица не диагональная");

        }
    }
}
