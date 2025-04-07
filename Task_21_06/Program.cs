namespace Task_21_06
{
    internal class Program
    {
        /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок*/
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<int> numbers = new List<int>();
            for (int i = 0; i < 20; i++)
               numbers.Add(rnd.Next(1,20));
            Console.WriteLine("Начальный список:");
            foreach(var num in numbers)
                Console.Write(num+" ");
            Console.WriteLine("\nСписок после очистки:");
            numbers = RemoveNumbers(numbers);
            foreach(var num in numbers)
                Console.Write(num+" ");

        }
        /// <summary>
        /// удаление повторяющихся чисел в списке
        /// </summary>
        /// <param name="numbers">начальный список чисел</param>
        /// <returns>новый список чисел</returns>
        static List<int> RemoveNumbers(List<int> numbers)
        {
            List<int> resultnumbers = new List<int>();
            foreach(var num in numbers)
            {
                if(!resultnumbers.Contains(num))
                    resultnumbers.Add(num);

            }
            return resultnumbers;
        }
    }
}
