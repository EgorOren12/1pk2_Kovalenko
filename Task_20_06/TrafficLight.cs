using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    internal class TrafficLight
    {
        public TrafficLightColor Color { get; set; } = TrafficLightColor.Red;
        private bool autoTraficLight = true;

        public void SwitchColour()
        {
            Console.WriteLine("Нажмите q для выхода;\nEnter для перехода в ручной режим переключения;\n");
            while (autoTraficLight)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Q)
                    {
                        autoTraficLight = false;
                        break;
                    }
                    else if (key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("\nПереход в ручной режим:\nДля выхода из ручного режима нажмите q\n" +
                            "Для переключения цветов нажмите Enter");
                        while (key == ConsoleKey.Enter)
                        {
                            key = Console.ReadKey(true).Key;
                            AutoSwitchColour();
                        }
                        Console.WriteLine("Переход в авторежим:\n");
                    }
                }                
                AutoSwitchColour();
                Thread.Sleep(3000);
            }
        }

        public void AutoSwitchColour()
        {
            switch (Color)
            {
                case TrafficLightColor.Red:
                    Color = TrafficLightColor.Green;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Зелёный");
                    break;
                case TrafficLightColor.Green:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Color = TrafficLightColor.Yellow;
                    Console.WriteLine("Жёлтый");
                    break;
                case TrafficLightColor.Yellow:
                    Color = TrafficLightColor.Red;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Красный");
                    break;
            }
            Console.ResetColor();
        }

    }
}
