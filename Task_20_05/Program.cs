namespace Task_20_05
{
    internal class Program
    {
        /*Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
        • Guest (только чтение)
        • User (чтение + комментарии)
        • Moderator (удаление контента)
        • Admin (полный доступ)
        Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
        На основе уровня доступа выводите сообщение (например,
        "Ошибка: Недостаточно прав!").*/
        static void Main(string[] args)
        {
            while (true)
            {
                int accesLevel, a;
                Console.WriteLine("Введите ваш уровень доступа:\n1.Гость\n2.Пользователь\n3.Модератор\n4.Админ");
                while (!int.TryParse(Console.ReadLine(), out accesLevel) || accesLevel > 4)
                    Console.WriteLine("Ошибка ввода");
                AccessLevel level = (AccessLevel)(accesLevel - 1);
                Console.WriteLine("Выберите действие:\n1.Чтение\n2.Чтение и коментарии\n3.Удаление контента\n4.Полный доступ");
                while (!int.TryParse(Console.ReadLine(), out a) || a > 4)
                    Console.WriteLine("Ошибка ввода");
                UserRights.VerifyingUserRights(level, a);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
