namespace Task_21_09
{
    internal class Program
    {
        /*создайте класс билета (Ticket). сгенерируйте список из 30 билетов. произведите:
        • поиск билета с максимальной суммой,
        • билета с минимальной суммой,
        • выведите список билетов с багажом
        • выведите список люготных билетов*/
        static void Main(string[] args)
        {
            Ticket ticket;
            List<Ticket> tickets = new List<Ticket>();
            for (int i = 0; i <= 30; i++) 
            {
            ticket = new Ticket();
            tickets.Add(ticket);
                ticket.TicketGetInfo();
            }

            Console.WriteLine("\nБилет с максимальной суммой:");
            int maxSumm = 0;
            foreach (var tic in tickets)
            {
                if (tic.Summ > maxSumm)
                    maxSumm = tic.Summ;
            }
            foreach (var tic in tickets)
            {
                if (tic.Summ == maxSumm)
                tic.TicketGetInfo();
            }

            Console.WriteLine("\nБилет с минимальной суммой:");
            int minSumm = maxSumm;
            foreach (var tic in tickets)
                if (tic.Summ < minSumm)
                    minSumm = tic.Summ;
            foreach (var tic in tickets)
                if (tic.Summ == minSumm)
                    tic.TicketGetInfo();

            Console.WriteLine("\nБилеты с багажом:");
            foreach (var tic in tickets)
                if (tic.Baggaje == true)
                    tic.TicketGetInfo();

            Console.WriteLine("\nБилеты с льготами:");
            foreach (var tic in tickets)
                if (tic.Benefits == true)
                    tic.TicketGetInfo();

        }
    }
}
