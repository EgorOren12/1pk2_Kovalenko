namespace Task_02_04
{
    internal class Program
    {
    /*       Пользователь вводит свою дату рождения построчно(сначала год, потом месяц и в конце дату) произведите
    расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
    этом*/
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свой год рождения");
            int yearbirt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой месяц рождения(числом)");
            int monthbirt = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите свой день рождения");
            int daybirt = int.Parse(Console.ReadLine());

            int curyear = 2025; int curmonth = 1; int curday = 17;
            int Age = curyear - yearbirt;
            if ((curmonth < monthbirt & Age == 18) || (curmonth == monthbirt & curday < daybirt))
                Age -= 1;
            Console.WriteLine(Age);
            if (Age >= 18)
                Console.WriteLine("Вы совершеннолетний");
            else
                Console.WriteLine("Вы несовершеннолетний");
        }
    }
}
