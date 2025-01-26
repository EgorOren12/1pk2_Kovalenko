namespace Task_05_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 50 случайных чисел. 
         * Найти количество пар элементов, значения
        которых равны.*/
        static void Main(string[] args)
        {
            int[] el = new int[50];
            Random rnd = new Random();
            int pary = 0;
            for (int i = 0; i < el.Length; i++) 
            {
                el[i] = rnd.Next(1, 11);
                Console.WriteLine($"{i}     {el[i]}");
            }
            for (int i = 0;i < el.Length; i++)
            {
                    for (int j = 0; j < i; ++j)
                    {
                        if (el[i] == el[j])
                        {
                            pary++;
                        }
                    }

            }
            Console.WriteLine($"Количество пар числе - {pary}");
        }

    }
}
