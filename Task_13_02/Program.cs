namespace Task_13_02
{
    internal class Program
    {
        /*создать класс питомца
        свойства:
        кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
        методы:
        вывод информации об объекте
        изменение значения веса животного
        изменение отметки о состоянии здоровья
        конструторы:
        предусмотрите разные варианты инициализации объектов*/
        static void Main(string[] args)
        {
            Pet pet1 = new Pet(); //объект 1
            pet1.Name = "Снежок";
            pet1.Kind = "Кот";
            pet1.Age = "7";
            pet1.Weight = "13";
            pet1.Health = "Здоров";
            Console.WriteLine(pet1.GetInfoAnimal());
            Console.WriteLine();
            //изменение веса и сост здоровья
            pet1.WeightChange("20");
            pet1.HealthChange("Не здоров");
            Console.WriteLine(pet1.GetInfoAnimal());
            Console.WriteLine();
            //объект 2 с отсутствующими параметрами
            Pet pet2 = new Pet();
            pet2.Name = "Бенита Сановна";
            pet2.Kind = "Собака";
            pet2.Age = null;
            pet2.Weight = null;
            pet2.Health = "Здорова";
            Console.WriteLine(pet2.GetInfoAnimal());
        }
    }
}

