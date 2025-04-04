namespace Task_21_08
{
    internal class Program
    {
        /*напишите метод, который на вход получается массив параметров (строк) и возвращает толькоуникальныестроки*/
        static void Main(string[] args)
        {
            string[] strings = { "Москва", "Уфа", "Пенза", "Питер", "Москва", "Уфа", "Казань","Пенза" };
            
            Console.WriteLine("Начальные строки - "+(string.Join(", ",strings)));
            string[] uniqueStrings = UniqueStrings(strings);
            Console.WriteLine("Уникальные строки - "+(string.Join(", ",uniqueStrings)));
        }

        public static string[] UniqueStrings(params string[] strings)
        {
           SortedSet<string> strings1 = new SortedSet<string>();
            foreach (string s in strings) 
            {
            strings1.Add(s);
            }
            return strings1.ToArray();
        }
    }
}
