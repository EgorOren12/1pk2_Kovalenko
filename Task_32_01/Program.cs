using System.Runtime.Intrinsics.X86;
using Task_32_01.Obstacles;

namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Kolobok kolobok = new Kolobok();
            List<Animal> animals = new List<Animal>
            {
                new Hare(),
                new Wolf(),
                new Bear(),
                new Fox()
            };
            List<Obstacle> obstacles = new List<Obstacle>
            {
                new Stone(),
                new Wall(),
                new River()
            };
            foreach (var animal in animals)
            {
                
                if (!kolobok.IsAlive || kolobok.Speed == 0)
                    break;
                kolobok.Roll();
                if (random.Next(0,2) == 1) //рандом препятствия для колобка
                {
                    kolobok.MeetObstacle(obstacles[random.Next(0,3)]);
                    if (kolobok.Speed == 0)
                        break ;
                }
                kolobok.MeetAnimal(animal);
                
            }
            if (kolobok.IsAlive && kolobok.Speed != 0)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else if (kolobok.Speed == 0)
            {
                Console.WriteLine("Колобок не смог сбежать из этого ООП-мира");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }

        }
    }
}
