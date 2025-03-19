using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    class Journal
    {
        public string date;
        public string theme;
        public string name;
        public int pages;
        public string price;
        bool buy = false;
        public void BuyJournal()
        {
            if (buy)
                Console.WriteLine($"Журнал {name} уже куплен");
            else
            {
                Console.WriteLine($"Цена для покупки журнала {name} - {price}\nЖурнал куплен\n");
                buy = true;
            }
        }
        public void JournalInfo()
        {
            Console.WriteLine($"Название журнала - {name}\nПредметно-тематическая направленность - {theme}" +
                $"\nДата издания - {date}\nКоличество страниц - {pages} страниц\nЦена - {price}");
        }
    }
}
