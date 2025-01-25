﻿using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения о количестве осадков за месяц (30 дней). Необходимо определить общее 
        количество осадков, выпавших за каждую декаду месяца, вывести день с самыми сильными осадками за месяц и 
        отдельно вывести дни без осадков. Массив с осадками заполнятся с помощью рандома в диапазоне от 0 – нет 
        осадков, до 300 мм выпавших осадков*/
        static void Main(string[] args)
        {
            int[] dni = new int[31]; int[] pref = new int[32];
            Random rnd = new Random();
            int sym1 = 0, sym2 = 0, sym3 = 0, maxday = 0, maxi = 0;
            string dnibez = "";
            for (int i = 1; i < 31; ++i) // предподсчет суммы задание нового массива
            {
                dni[i] = rnd.Next(0, 300);
                pref[i + 1] = dni[i] + pref[i];

            }
            sym1 = pref[11] - pref[1];
            sym2 = pref[21] - pref[11];
            sym3 = pref[31] - pref[21];      // 11
            for (int i = 1; i < 31; ++i)
            {
                if (Math.Max(maxi, dni[i]) == dni[i])
                {
                    maxi = dni[i];
                    maxday = i;
                }
                if (dni[i] == 0)
                {
                    dnibez += $" {i}";
                }
                Console.WriteLine(i + "    " + dni[i]);
            }
            if (dnibez == "")
                dnibez = "Нет";
            Console.WriteLine($"За первую декаду :\nОбщее количество осадков составило {sym1}мм\n\nЗа вторую декаду :\nОбщее количество осадков составило {sym2}мм\n" +
                $"\nЗа третью декаду :\nОбщее количество осадков составило {sym3}мм\n\nДень с максимальным количеством осадков - {maxday} - {maxi}мм\n" +
                $"\nДни без осадков - {dnibez}");
            
        }
    }
}


