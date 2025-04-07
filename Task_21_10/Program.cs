namespace Task_21_10
{
    internal class Program
    {
        /*Написать метод, который объединяет два словаря. Если ключ присутствует в обоих словарях, суммировать их значения.*/

        static void Main(string[] args)
        {
        Dictionary<string,int> dictionary1 = new Dictionary<string, int>()
        {
            {"Задача 1", 15 },
            {"Задача 2", 1478},
            {"Сумма", 1568},
            {"Чек номер 2 ", 125 },
            {"Баланс карты", 10125 },
        };
            Console.WriteLine("Словарь 1:\n");
            foreach (var key in dictionary1)
            {
                Console.WriteLine($"{key.Key} - {key.Value}");
            }
            Console.WriteLine();

            Dictionary<string, int> dictionary2 = new Dictionary<string, int>()
        {
            { "Год", DateTime.Now.Year},
            { "Задача 2", 1589},
            { "Зачет", 27},
            { "Чек номер 2 ", 5987 },
            { "Номер билета", 101254584 },
            {"Номер заказа", 698 }
        };
            Console.WriteLine("Словарь 2:\n");
            foreach (var key in dictionary2)
            {
                Console.WriteLine($"{key.Key} - {key.Value}");
            }
            Console.WriteLine();

            Dictionary<string, int> newDictionaty = GetAllDictionaries(dictionary1, dictionary2);
            Console.WriteLine("Объединенный словарь:\n");
        foreach (var key in newDictionaty)
            {
                Console.WriteLine($"{key.Key} - {key.Value}");
            }
        }
        /// <summary>
        /// объединение 2ух словарей
        /// </summary>
        /// <param name="d1">1 словарь</param>
        /// <param name="d2">2 словарь</param>
        /// <returns>новый объединенный словарь</returns>
        public static Dictionary<string,int> GetAllDictionaries(Dictionary<string,int> d1, Dictionary<string, int> d2)
        {
            Dictionary<string,int> allDictionary = new Dictionary<string,int>();
            foreach(var key1 in d1)
            {
                allDictionary.Add(key1.Key, key1.Value);
            }
            foreach(var key2 in d2)
            {
                if (!allDictionary.ContainsKey(key2.Key))
                    allDictionary.Add(key2.Key, key2.Value);
                else if (allDictionary.ContainsKey(key2.Key))
                    allDictionary[key2.Key] += key2.Value;
            }
            return allDictionary;

        }
    }
}
