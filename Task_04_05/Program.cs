using System.ComponentModel.DataAnnotations;

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
            int [] dni = new int[30];
            Random rnd = new Random();
            int sym = 0, maxi = 0, maxday=0;
            string dnibez = "";
            for (int i = 0; i < dni.Length; i++) 
            {
                dni[i] = rnd.Next(0,300);
                sym += dni[i];
                maxi = Math.Max(maxi, dni[i]);
                if (maxi == dni[i]) 
                {
                    maxday = i;
                }
                if (dni[i] == 0) 
                {
                dnibez += $"{i} ";
                }
            }
            if (dnibez == "") 
            {
                dnibez = "Нет";
            }
            Console.WriteLine($"Общее количество осадков - {sym}мм\nДень с самым большим количеством осадков - {maxday} в который выпало {maxi}мм\nДни в которые не было осадков: {dnibez}");
        }
    }
}
