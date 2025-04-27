using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01.Obstacles
{
    public class Stone : Obstacle
    {
        public Stone() : base("Камень") { }
        public override bool CanStop(Kolobok kolobok)
        {
            return false;
        }
    }
}
