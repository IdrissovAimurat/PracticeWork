using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWork
{
    public abstract class Storage
    {
        private string name;
        private string model;
        protected double usedMemory;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public abstract double GetMemoryCapacity();
        public abstract void CopyData(double dataAmount);
        public abstract double GetFreeMemory();
        public abstract string GetDeviceInfo();
    }
}
