using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    internal class Ticket
    {
        public int Summ {  get; set; }
        public bool Baggaje { get; set; }
        public bool Benefits { get; set; }

        public Ticket() 
        {
        Random rnd = new Random();
            Summ = rnd.Next(1000,5000);
            int randomBaggaje = rnd.Next(0, 2);
            if (randomBaggaje == 0)
                Baggaje = true;
            else
                Baggaje = false;

            int randomBenefits = rnd.Next(0, 2);
            if (randomBenefits == 0)
                Benefits = true;
            else
                Benefits = false;
        }
        public void TicketGetInfo()
        {
            Console.WriteLine($"Билет на сумму - {Summ}, Багаж? - {Baggaje}, Льготный? - {Benefits}");
        }
    }
}
