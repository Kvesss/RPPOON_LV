using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD4
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            float difference = Math.Abs((float)(currentLoad - this.previousCPULoad)/this.previousCPULoad);
            if (difference >= 0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentRAM = this.AvailableRAM;
            float difference = Math.Abs((currentRAM - this.previousRAMAvailable) / this.previousRAMAvailable);
            if (difference >= 0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentRAM;
            return currentRAM;
        }

    }
}
