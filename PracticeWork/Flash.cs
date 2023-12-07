using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    public class Flash : Storage
    {
        public double USB3Speed { get; set; }
        public double MemoryCapacity { get; set; }

        public Flash(string name, string model, double usb3Speed, double memoryCapacity)
        {
            Name = name;
            Model = model;
            USB3Speed = usb3Speed;
            MemoryCapacity = memoryCapacity;
        }

        public override double GetMemoryCapacity()
        {
            return MemoryCapacity;
        }

        public override void CopyData(double dataAmount)
        {
            double timeRequired = dataAmount / USB3Speed;
            usedMemory += dataAmount;
            Console.WriteLine($"Время копирования данных на Flash: {timeRequired} секунд.");
        }

        public override double GetFreeMemory()
        {
            return MemoryCapacity * 1024 - usedMemory;
        }

        public override string GetDeviceInfo()
        {
            return $"Flash: {Name}, Модель: {Model}, Объем: {MemoryCapacity} Гб (Гигабайт), USB 3.0 Скорость: {USB3Speed} Мб/см (Мегабайт/сек)";
        }
    }
}
