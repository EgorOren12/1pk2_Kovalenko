namespace Task_03_4
{
    /*Пользователь вводить в консоли произвольный текст. 
     * После каждого ввода консоль очищается. 
     * Когда пользователь вводить слово «exit» или пустую строку
     * – ввод останавливается и выводиться количество строк 
     * введенных пользователем.*/
    internal class Program
    {
        static void Main(string[] args)
        {
        string a = Console.ReadLine();
            string b = "";
            while (a != "exit" | a != "" )
                
            { 
                b += a + "\n";
                Console.Clear();
            a = Console.ReadLine();
                if (a == "exit" | a == "")
                    break;
            }
            Console.Clear();
            Console.WriteLine(b);
        }
    }
}
