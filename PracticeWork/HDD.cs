using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    public class HDD : Storage
    {
        public double USB2Speed { get; set; }
        public int PartitionCount { get; set; }
        public double PartitionSize { get; set; }

        public HDD(string name, string model, double usb2Speed, int partitionCount, double partitionSize)
        {
            Name = name;
            Model = model;
            USB2Speed = usb2Speed;
            PartitionCount = partitionCount;
            PartitionSize = partitionSize;
        }

        public override double GetMemoryCapacity()
        {
            return PartitionSize * PartitionCount;
        }

        public override void CopyData(double dataAmount)
        {
            double timeRequired = dataAmount / USB2Speed;
            usedMemory += dataAmount;
            Console.WriteLine($"Время копирования данных на HDD: {timeRequired} секунд.");
        }

        public override double GetFreeMemory()
        {
            return GetMemoryCapacity() * 1024 - usedMemory;
        }

        public override string GetDeviceInfo()
        {
            return $"HDD: {Name}, Модель: {Model}, USB 2.0 Скорость: {USB2Speed} Мб/с, Разделов: {PartitionCount}, Размер раздела: {PartitionSize} Гб (Гигабайт)";
        }
    }
}
