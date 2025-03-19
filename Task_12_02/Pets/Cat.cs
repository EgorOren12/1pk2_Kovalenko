using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Pets
{
    class Cat
    {
        public string name;
        public int age;
        public string kind;
        bool iseat = false;
        bool fight = false;
        /// <summary>
        /// информация о коте
        /// </summary>
        public void CatGetInfo()
        {
            Console.WriteLine($"Кот {name}, возраст - {age}, порода - {kind}");
        }
        /// <summary>
        /// кормление кота
        /// </summary>
        public void Eat()
        {
            if (iseat == false)
            {
                Console.WriteLine("Кот проголодался\nВы покормили кота");
                iseat = true;
            }
            else
            {
                Console.WriteLine("Кот был покормлен недавно");
                
            }
        }
        /// <summary>
        /// драка кота и собаки
        /// </summary>

        public void Fight()
        {
            if (fight == false)
            {
                Console.WriteLine("Кот и собака подрались");
                fight = true;
            }
            else
            {
                Console.WriteLine("Кот и собака в разных комнатах");


            }
        }
    }
}
