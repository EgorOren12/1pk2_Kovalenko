namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
        Фаренгейта (F = C*1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
        время работы программы*/
        static void Main(string[] args)
        {
            Console.WriteLine("Диапазон изменения температуры в градусах Цельсия и шаг изменения температуры. ");
            int a1 = int.Parse(Console.ReadLine());  int a2 = int.Parse(Console.ReadLine()); int shag = int.Parse(Console.ReadLine());
            for (int i = 0; a1 + shag < a2; i += shag)
            {
                Console.WriteLine((a1 + i) * 1.8 + 32);
                if (a1 + i >= a2) 
                {
                    break;

                }
            }
        }
    }
}
