using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    internal class UserRights
    {
        /// <summary>
        /// верификация уровня доступа
        /// </summary>
        /// <param name="level">текущий уровень доступа</param>
        /// <param name="n">действие пользователя(чтение и тд)</param>
        public static void VerifyingUserRights(AccessLevel level, int n)
        {
            switch (n)
            {
                case 1:
                    if (level >= AccessLevel.Guest)
                        Console.WriteLine("Вам доступно чтение");
                    else
                        Console.WriteLine("Недостаточно прав");
                    break;
                case 2:
                    if (level >= AccessLevel.User)
                        Console.WriteLine("Вам доступно чтение и коментарии");
                    else
                        Console.WriteLine("Недостаточно прав");
                    break;
                case 3:
                    if (level >= AccessLevel.Moderator)
                        Console.WriteLine("Вам доступно чтение,коментарии и удаление контента");
                    else
                        Console.WriteLine("Недостаточно прав");
                    break;
                case 4:
                    if (level == AccessLevel.Admin)
                        Console.WriteLine("У вас полное право доступа");
                    else
                        Console.WriteLine("Недостаточно прав");
                    break;
            }
            
        }
    }
}
