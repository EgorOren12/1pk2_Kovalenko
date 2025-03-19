namespace Task_14_04
{
    internal class Program
    {
        /*Определите класс User, который будет иметь статическое свойство CurrentUser, 
         * представляющее текущего пользователя, и метод для его установки.*/
        static void Main(string[] args)
        {
            User user1 = new User();
            User.SetCurrentUser("Андрей");
            Console.WriteLine(User.CurrentUser);

            User user2 = new User();
            User.SetCurrentUser("Дэйнерис Таргариен");
            Console.WriteLine(User.CurrentUser);
        }
    }
}
