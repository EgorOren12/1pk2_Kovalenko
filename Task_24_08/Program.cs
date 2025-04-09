using System.IO;

namespace Task_24_08
{
    internal class Program
    {
        /*реализуйте функцию, осуществляющую поиск текста в файле и его замену на значения, введенныепользователем*/
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
                Console.WriteLine("Введите текст который вы хотите заменить:");
                string foundText = Console.ReadLine();
                Console.WriteLine("Введите текст на который вы хотите заменить:");
                string replaceText = Console.ReadLine();
                ReplaceText(path, foundText, replaceText);
            }
        }
        /// <summary>
        /// заменяет текст на заданное пользователем значение текста
        /// </summary>
        /// <param name="path">название файла</param>
        /// <param name="findText">текст на замену</param>
        /// <param name="replaceText">заданное пользователем значение текста</param>
        public static void ReplaceText(string path, string findText, string replaceText)
        {
            string text;
            using (StreamReader reader = new StreamReader(path))
            {
            text = reader.ReadToEnd();
            }
            string newText = text.Replace(findText,replaceText);
            Console.WriteLine("\n"+newText);
        }
    }
}
