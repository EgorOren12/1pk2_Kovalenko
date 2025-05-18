using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_39_02
{
    public class Product 
    {
        public string Name { get; set; }
        public int Count { get; set; }

        public Product(string name, int count) 
        {
            Name = name;
            Count = count;
        }
        public override string ToString()
        {
            return $"{Name} - {Count}";
        }


        
    }
}
