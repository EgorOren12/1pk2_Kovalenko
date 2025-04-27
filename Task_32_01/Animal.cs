using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public abstract class Animal
    {
        public string Name { get; set; }
        protected Animal(string name)
        {
            Name = name;
        }
        public abstract bool CanEat(Kolobok kolobok);
    }
}
