using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01.Obstacles
{
    public class Wall : Obstacle
    {
        public Wall() : base("Стена") { }
        public override bool CanStop(Kolobok kolobok)
        {
            return false;
        }
    }
}
