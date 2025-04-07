using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_04
{
    /*    Храните список транспортных средств (можно просто List<VehicleType>). 
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
    Реализуйте поиск по типу и вывод информации*/
    internal static class Vehicle
    {
        static public List<VehicleType> Vehicles { get; set; } = new List<VehicleType>() {         
           VehicleType.Car,
           VehicleType.Bike,
           VehicleType.Bus,
           VehicleType.Truck,
           VehicleType.Motorcycle,
           VehicleType.Car,
           VehicleType.Bike
        };
        /// <summary>
        /// подсчитывает количество определенного транспорта
        /// </summary>
        /// <param name="vehicleIndex">тип транспорта</param>

        static public void GetCountOfVehicleType(int vehicleIndex)
        {
            int count = 0;
            foreach (var vehicle in Vehicles)
            {
                if (vehicle == (VehicleType)vehicleIndex)
                    count++;
            }
            Console.WriteLine($"Транспортных средств типа {(VehicleType)vehicleIndex} - {count}");
        }

    }
}
