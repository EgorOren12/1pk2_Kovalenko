using Task_12_02.Pets;

namespace Task_12_02
{
    internal class Program
    {
        /*создайте проект с классом Cat и Dog, полностью самостоятельно продумайте 
         * данные для объектов класса и их функционал*/
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.name = "Снежок";
            cat.age = 7;
            cat.kind = "Шотландская вислоухая";
            cat.CatGetInfo();
            cat.Eat();
            cat.Eat();
            cat.Fight();
            cat.Fight();
            Console.WriteLine("\n");

            Dog dog = new Dog();
            dog.name = "Умка";
            dog.age = 3;
            dog.kind = "Дворняжка";
            dog.DogGetInfo();
            dog.Eat();
            dog.Eat();
            dog.Walk();
            dog.Walk();
            dog.Play();
            dog.Play();
        }
    }
}
