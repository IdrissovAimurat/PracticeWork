using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {

               Flash flashDrive = new Flash("Flash", "Flash-память", 100, 32);
                        
                        DVD dvd = new DVD("DVD", "DVD-диск", 10, true);

                        HDD hdd = new HDD("HDD", "съемный HDD", 60, 4, 250);

             Storage[] storages = { flashDrive, dvd, hdd };

            double dataToCopy = 565 * 1024;
            double totalMemory = 0;

            foreach (Storage storage in storages)
            {
                totalMemory += storage.GetMemoryCapacity();
            }
            Console.WriteLine($"Общий объем памяти всех устройств: {totalMemory} Гб (Гигабайт)");

            foreach (Storage storage in storages)
            {
                storage.CopyData(dataToCopy);
            }

            foreach (Storage storage in storages)
            {
                double numberOfDevicesNeeded = Math.Ceiling(dataToCopy / (storage.GetMemoryCapacity() * 1024));
                Console.WriteLine($"Для переноса {dataToCopy} Мб (Мегабайт) на {storage.Name} потребуется {numberOfDevicesNeeded} устройств(-а).");
            }
            Console.ReadKey();
        }
    }
}
