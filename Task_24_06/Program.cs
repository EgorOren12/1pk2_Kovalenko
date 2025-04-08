using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;

namespace Task_24_06
{
    internal class Program
    {
        /*Напишите метод, который принимает путь к файлу и возвращает количество строк в нем. ИспользуйтеStreamReader*/
        static void Main(string[] args)
        {
            string path = @"C:\Users\Пользователь\source\repos\1pk2_Kovalenko\Task_24_06\bin\Debug\net8.0\text.txt";
            string text = "Сегодня солнечный день, и я планирую прогуляться в парке.\n" +
                " Ветер свежий, и деревья нежно шепчут свои тайны. \n" +
                "Я люблю наблюдать за птицами, которые порхают между ветвями. \n" +
                "Можно взять с собой книгу и почитать на скамейке. \n" +
                "Надеюсь, что встречу старых друзей и поговорю с ними. \n" +
                "Вечером готовлюсь попробовать новый рецепт пасты. \n" +
                "Жизнь полна маленьких радостей, и я стараюсь их замечать.";
            FileInfo fileInfo = new FileInfo(path);

            File.Create(path).Dispose();
            File.WriteAllText(path, text);

            if (!File.Exists(path))
            {
                Console.WriteLine($"Папки {fileInfo.Name} не существует по указанному пути");
            }
            else {
                Console.WriteLine($"Количество строк в файле {fileInfo.Name} по пути {path} - {GetCountOfLinesOfText(path)}");
                 } 
        }
        /// <summary>
        /// возвращает кол-во строк в файле
        /// </summary>
        /// <param name="path">путь файла</param>
        /// <returns>кол-во строк</returns>
        public static int GetCountOfLinesOfText(string path)
        {
            int count = 0;
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                    count++;
                    return count;
            }
        }
    }
}
