using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Pets
{
    class Dog
    {
        public string name;
        public int age;
        public string kind;
        bool wantotplay = true;
        bool gotowalk = true;
        bool iseat = false;
        /// <summary>
        /// информацио о собаке
        /// </summary>
        public void DogGetInfo()
        {
            Console.WriteLine($"Собака {name}, возраст - {age}, порода - {kind}");
        }
        /// <summary>
        /// кормление собаки
        /// </summary>
        public void Eat()
        {
            if (iseat == false)
            {
                
                Console.WriteLine("Собака проголодалась\nВы покормили собаку");
                iseat = true;
            }
            else
                Console.WriteLine("Собака была покормлена недавно");
        }
       /// <summary>
       /// прогулка с собакой
       /// </summary>
        public void Walk()
        {
            if (gotowalk)
            {
                Console.WriteLine("Собака хочет гулять\nВы пошли гулять с собакой");
                gotowalk = false;
            }
            else
                Console.WriteLine("Вы гуляли с собакой недавно");
        }
        /// <summary>
        /// игра с собакой
        /// </summary>
        public void Play()
        {
            if (wantotplay)
            {
                Console.WriteLine("Собака хочет поиграть\nВы начали играть с собакой");
                wantotplay= false;
            }
            else
                Console.WriteLine("Собака устала");
        }

    }
}

