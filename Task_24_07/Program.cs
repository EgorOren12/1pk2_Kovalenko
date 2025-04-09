namespace Task_24_07
{
    internal class Program
    {
        /*Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки, содержащие это слово (регистронезависимо).*/
        static void Main(string[] args)
        {
            string path = "text.txt";
            string text = "Сегодня солнечный день, и я планирую прогуляться в парке.\n" +
                " Ветер свежий, и деревья нежно шепчут свои тайны. \n" +
                "Я люблю наблюдать за птицами, которые порхают между ветвями. \n" +
                "Можно взять с собой книгу и почитать на скамейке. \n" +
                "Надеюсь, что встречу старых друзей и поговорю с ними. \n" +
                "Вечером готовлюсь попробовать новый рецепт пасты. \n" +
                "Жизнь полна маленьких радостей, и я стараюсь их замечать.";
            File.Create(path).Dispose();
            File.WriteAllText(path, text);

            FileInfo fileInfo = new FileInfo(path);

            if (!File.Exists(path))
            {
                Console.WriteLine($"Папки {fileInfo.Name} не существует по указанному пути");
            }
            else
            {
                Console.WriteLine("Введите слово для поиска в тексте:");
                string word = Console.ReadLine();
                Console.WriteLine($"Строки с заданым словом {word}:\n\n{FindCurWord(path, word)}");
            }

        }
        
        
        /// <summary>
        /// находит строки с заданным словом
        /// </summary>
        /// <param name="path">текстовый файл</param>
        /// <param name="curWord"></param>
        /// <returns></returns>
        public static string FindCurWord(string path, string curWord)
        {
            string curWordLine = "";
            using (StreamReader stream = new StreamReader(path))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    string[] curline = line.Split(' ');
                    for (int i = 0; i < curline.Length; i++)
                    {
                        curline[i] = curline[i].ToLower();
                    }
                    foreach (string cur in curline)
                    {                  
                        if (cur == curWord.ToLower())
                            curWordLine += line + "\n";
                    }
                }
            }
            return curWordLine;
        }
    }
}
