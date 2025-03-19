using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    class Newspaper
    {
        public string name;
        public string price; 
        public string mainline;
        public string pages;
        public string date;
        bool notinrange = false;
        /// <summary>
        /// покупка газеты
        /// </summary>
        public void BuyNewspaper()
        {
            if (notinrange)
                Console.WriteLine($"Газета {name} в вашем районе закончилась.");
            else
            {
                Console.WriteLine($"Цена газеты {name} - {price}\nГазета куплена");
                notinrange = true;
            }

        }
       /// <summary>
       /// информацио о газете
       /// </summary>
        public void GetInfoNewsPaper()
        {
            Console.WriteLine($"Название газеты - {name}\nЗаголовок главной полосы - {mainline}" +
                $"\nДата издания - {date}\nКоличество страниц - {pages} страниц\nЦена - {price}\n");
        }



    }
}
