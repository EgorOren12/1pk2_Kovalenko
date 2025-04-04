namespace Task_21_07
{
    internal class Program
    {
        /*Написать метод, который находит первый ключ в словаре, 
         * соответствующий заданному значению. Если значения нет, вернуть null.*/
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionaty = new Dictionary<string, string>()
            {
                {"Обама", "Барак" },
                {"Горбачев","Михаил"},
                {"Романов","Михаил" },
                {"Рюрикович","Иван" }
            };
            Console.WriteLine("Введите искомое значение:");
            string value = Console.ReadLine();
            Console.WriteLine(FoundKey(dictionaty,value));
        }

        static string FoundKey(Dictionary<string, string> dictionary, string currentValue)
        {
            foreach (var value in dictionary)
            {
                if (value.Value.Equals(currentValue))
                {
                    return value.Key;
                }
            }
            return null;
        }
    }
}
