using System.Diagnostics;

namespace Task_23_06
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
        1. Выведите информации о всех дисках в системе
        2. Выведите содержимое каталога C:\Users (названия папок)
        3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
        a) Создание вложенного каталога “temp”
        b) Вывод информации о текущем каталоге (имя, родитель и тд)
        c) Вывод информации о вложенном каталоге
        4. Переместите каталог “temp” по пути “D:\work\newTemp”
        a) Реализуйте вывод информационного сообщения об успешном (или нет)
        перемещении
        5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
        удалении.*/
        static void Main(string[] args)
        {
            #region 1
            List<DriveInfo> directories = DriveInfo.GetDrives().ToList();
            Console.WriteLine("Информация о дисках в системе:");
            foreach (var item in directories)
            {
                Console.WriteLine($"\tДиск {item.Name}\n" +
                    $"\tРазмер диска - {item.TotalSize / 1024 / 1024 / 1024}Гб,\n\t" +
                    $"Доступно места - {item.AvailableFreeSpace / 1024 / 1024 / 1024}Гб,\n\t" +
                    $"Тип диска - {item.DriveType},\n\t" +
                    $"Метка диска - {item.VolumeLabel}\n");
            }
            #endregion
            #region 2
            Console.WriteLine(@"Cодержимое каталога C:\\Users:");
            string dir = @"C:\Users";
            if (Directory.Exists(dir))
            {
                List<string> list = Directory.GetDirectories(dir).ToList();
                if (list.Count > 0)
                {
                    foreach (string item in list)
                        Console.WriteLine("\t"+item);
                }
                else
                    Console.WriteLine("Каталог пуст");
            }
            else
                Console.WriteLine("Каталога не существует");
            #endregion
            #region 3
            Console.WriteLine();
            string driverDWork = @"D:\work";
            if (!Directory.Exists(driverDWork))
            {
                Directory.CreateDirectory(driverDWork);
                Console.WriteLine("Папка work создана\n");
            }
            else
                Console.WriteLine($"Папка work уже существует по пути {driverDWork}\n");

            string currentDir = driverDWork;
            string subCurDir = "temp";

            DirectoryInfo directoryInfoCurDir = new DirectoryInfo(currentDir);

            if (Directory.Exists(Path.Combine(currentDir, subCurDir)))
            {
                Console.WriteLine($"Вложенный каталог {subCurDir} уже существует\n");
            }
            else
            {
                directoryInfoCurDir.CreateSubdirectory(subCurDir);
                Console.WriteLine($"Вложенный каталог {subCurDir} создан\n");
            }

            Console.WriteLine($"Информация о текущем каталоге {directoryInfoCurDir.Name}:\n" +
                $"\tИмя - {directoryInfoCurDir.Name}\n" +
                $"\tПолное имя - {directoryInfoCurDir.FullName}\n" +
                $"\tРодительский каталог - {directoryInfoCurDir.Parent} \n" +
                $"\tКорневой каталог - {directoryInfoCurDir.Root} \n" +
                $"\tДата создания - {directoryInfoCurDir.CreationTime}\n" +
                $"\tДата последнего доступа - {directoryInfoCurDir.LastAccessTime}\n" +
                $"\tДата последнего изменения - {directoryInfoCurDir.LastWriteTime}\n");

            DirectoryInfo directoryInfoSubDir = new DirectoryInfo(currentDir + @"\" + subCurDir);

            Console.WriteLine($"Информация о вложенном катологе каталоге {subCurDir}:\n" +
                $"\tИмя - {directoryInfoSubDir.Name}\n" +
                $"\tПолное имя - {directoryInfoSubDir.FullName}\n" +
                $"\tРодительский каталог - {directoryInfoSubDir.Parent} \n" +
                $"\tКорневой каталог - {directoryInfoSubDir.Root} \n" +
                $"\tДата создания - {directoryInfoSubDir.CreationTime}\n" +
                $"\tДата последнего доступа - {directoryInfoSubDir.LastAccessTime}\n" +
                $"\tДата последнего изменения - {directoryInfoSubDir.LastWriteTime}\n");
            #endregion
            #region 4 и 5
            string path = Path.Combine(driverDWork, "newTemp");
            if (Directory.Exists(Path.Combine(driverDWork, "temp")))
            {
                Directory.Move(directoryInfoSubDir.ToString(), path);
                Console.WriteLine($"Успешное перемещение каталога {directoryInfoSubDir.Name} в {path}\n");
            }
            else
                Console.WriteLine($"Каталог {directoryInfoSubDir.Name} не найден");
            
            if (Directory.Exists(Path.Combine(driverDWork, "temp")))
            {
                directoryInfoSubDir.Delete(true);
                Console.WriteLine($"Каталог {directoryInfoSubDir.Name} успешно удален");
            }
            else
                Console.WriteLine($"Каталог {directoryInfoSubDir.Name} не удален, тк  не найден");
            #endregion
        }
    }
}
