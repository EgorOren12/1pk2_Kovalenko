using System.Reflection.Emit;

namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
        • 1 столбец содержит нули
        • 2 столбце содержит числа кратные 2
        • 3 столбец содержит числа кратные 3
        • 4 столбец содержит числа кратные 4
        • 5 столбец содержит числа кратные 5*/
        static void Main(string[] args)
        {
            int[,] mass = new int[10,5];
            int[,] mass2 = new int[5, 10];
            Random rnd = new Random();
            Console.WriteLine("Изначальный массив:");
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    while(true)
                    {
                        int num = rnd.Next(0, 100);
                        if (num == 0 & j == 0)
                        {
                            mass[i,j] = num;
                            break;

                        }
                        if (num % 2 == 0 & j == 1 & num != 0)
                        {
                            mass[i,j] = num;
                            break;
                        }
                        if(num % 3 == 0 & j == 2 & num != 0)
                        {
                            mass[i,j] = num;
                            break;
                        }
                        if(num % 4 == 0 & j == 3 & num != 0)
                        {
                            mass[i,j] = num;
                            break;
                        }
                        if(num % 5 == 0 & j == 4 & num != 0) 
                        {
                            mass[i,j] = num;
                            break;
                        }

                    }
                    Console.Write(mass[i,j]+"   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Обновленный массив:");
            for (int i = 0;i < mass.GetLength(0); i++)
            {
                for(int j = 0;j < mass.GetLength(1); j++)
                {
                    mass2[j,i] = mass[i,j];
                }
            }
            for (int i = 0; i < mass2.GetLength(0); i++)
            { 
            for (int j = 0; j < mass2.GetLength(1); j++)
                {
                    Console.Write(mass2[i,j]+"  ");
                }
            Console.WriteLine();
            }

        }
    }
}
