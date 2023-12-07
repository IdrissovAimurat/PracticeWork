using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    public class DVD : Storage
    {
        public double ReadWriteSpeed { get; set; }
        public bool IsDoubleSided { get; set; }

        public DVD(string name, string model, double readWriteSpeed, bool isDoubleSided)
        {
            Name = name;
            Model = model;
            ReadWriteSpeed = readWriteSpeed;
            IsDoubleSided = isDoubleSided;
        }
        public override double GetMemoryCapacity()
        {
            return IsDoubleSided ? 9 : 4.7;
        }
        public override void CopyData(double dataAmount)
        {
            double timeRequired = dataAmount / ReadWriteSpeed;
            usedMemory += dataAmount;
            Console.WriteLine($"Время копирования данных на DVD: {timeRequired} секунд.");
        }
        public override double GetFreeMemory()
        {
            return GetMemoryCapacity() * 1024 - usedMemory;
        }

        public override string GetDeviceInfo()
        {
            string sideInfo = IsDoubleSided ? "двусторонний" : "односторонний";
            return $"DVD: {Name}, Модель: {Model}, Тип: {sideInfo}, Объем: {GetMemoryCapacity()} Гб, Скорость: {ReadWriteSpeed} Мб/с";
        }
    }
}
