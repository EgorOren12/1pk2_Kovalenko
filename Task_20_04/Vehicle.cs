using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    /*    Храните список транспортных средств (можно просто List<VehicleType>). 
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
    Реализуйте поиск по типу и вывод информации*/
    internal class Vehicle
    {
        public List<VehicleType> vehicleTypes { get; set; }
        public Vehicle()
        {
            vehicleTypes = new List<VehicleType>();
        }

    }
}
