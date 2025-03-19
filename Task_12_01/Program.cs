using Task_12_01.Publications;

namespace Task_12_01
{
    internal class Program
    {
        /*в этом же проекте реализуйте класс Journal (журнал) со следующими данными:
дата издания, предметно-тематическая направленность журнала, название, количество страниц, ценафункционал класса:
покупка журнала
просмотр содержания журнала
в этом же проекте реализуйте класс Newspaper (газета) со следующими данными:
дата издания, название газеты, заголовок главной полосы, количество страниц, цена
функционал класса:*/
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };

            


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю
            Console.WriteLine("\n");
            Journal journal1 = new Journal() { name = "National Geographic", price = "20 долларов", date = "Октябрь 2023", theme = "Научно-популярный, природа, география, культура", pages = 100 };
            Journal journal2 = new Journal() { name = "TIME", price = "10 долларов", date = "Декабрь 2024", theme = "Политика, общественные события, культура, новости", pages = 85 };
            journal1.JournalInfo();
            journal1.BuyJournal(); //покупка журнала
            journal1.BuyJournal(); //журнал куплен
            journal2.JournalInfo();
            journal2.BuyJournal();//покупка журнала

            Newspaper newspaper1 = new Newspaper() { name = "ОКЭИ news", price = "30 Рублей", date = "Январь 2024", mainline = "Скоро праздники!", pages = "15" };
            newspaper1.GetInfoNewsPaper();
            newspaper1.BuyNewspaper();
            newspaper1.BuyNewspaper();
        }
    }
}
