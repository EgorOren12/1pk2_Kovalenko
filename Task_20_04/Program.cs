namespace Task_20_04
{
    internal class Program
    /*Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
    • Car
    • Bike
    • Bus
    • Truck
    • Motorcycle
    Храните список транспортных средств (можно просто List<VehicleType>). 
    Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
    Реализуйте поиск по типу и вывод информации*/
    {
        static void Main(string[] args)
        {
            int kindOfVehicle;
            Console.WriteLine("Количество каких т/с вы хотите подсчитать:\n1-Машины\n2-Велосипеды\n3-Автобусы\n4-Грузовики\n5-Мотоциклы");
            while(!int.TryParse(Console.ReadLine(),out kindOfVehicle))
            {
                Console.WriteLine("Ошибка ввода");
            }
            Console.Clear();
            Vehicle.GetCountOfVehicleType(kindOfVehicle - 1);
        }
    }
}
