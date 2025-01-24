using System.ComponentModel.DataAnnotations;
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
            int sym1 = 0, sym2 = 0, sym3 = 0, maxday1 = 0, maxday2 = 0, maxday3 = 0, maxi1 =0,maxi2= 0,maxi3=0;
            string dnibez1 = "", dnibez2 = "", dnibez3 = "";
            for (int i = 1; i < 31; ++i) // предподсчет суммы задание нового массива
            {
                dni[i] = rnd.Next(0, 300);
                pref[i + 1] = dni[i] + pref[i];

            }
            sym1 = pref[11] - pref[1];
            sym2 = pref[21] - pref[11];
            sym3 = pref[31] - pref[21];      // 11
            for (int i = 1; i < 11; ++i) //1 декада
            {
                int maxi = 0;
                if (Math.Max(dni[i], maxi1) == dni[i])
                {
                    maxi1 = dni[i];
                    maxday1 = i;
                }
                if (dni[i] == 0)
                {
                    dnibez1 += $" {i}";
                }
                else
                    dnibez1 = "Нет";
            }
            for (int i = 11; i < 21; ++i) //2 декада
            {
                int maxi = 0;
                if (Math.Max(dni[i], maxi2) == dni[i])
                {
                    maxi2 = dni[i];
                    maxday2 = i;
                }
                if (dni[i] == 0)
                {
                    dnibez2 += $" {i}";
                }
                else
                    dnibez2 = "Нет";
            }
            for (int i = 21; i < 31; ++i) //3 декада 
            {
                int maxi = 0;
                if (Math.Max(dni[i], maxi3) == dni[i])
                {
                    maxi3 = dni[i];
                    maxday3 = i;
                }
                if (dni[i] == 0)
                {
                    dnibez3 += $" {i}";
                }
                else
                    dnibez3 = "Нет";
            }
            Console.WriteLine($"За первую декаду :\nОбщее количество осадков составило {sym1}мм\nДень с максимальным количеством осадков - {maxday1} - {maxi1}мм\nДни без осадков - {dnibez1}\n" +
                $"\nЗа вторую декаду :\nОбщее количество осадков составило {sym2}мм\nДень с максимальным количеством осадков - {maxday2} - {maxi2}мм\nДни без осадков - {dnibez2}\n" +
                $"\nЗа третью декаду :\nОбщее количество осадков составило {sym3}мм\nДень с максимальным количеством осадков - {maxday3} - {maxi3}\nДни без осадков - {dnibez3}");
        }
    }
}


