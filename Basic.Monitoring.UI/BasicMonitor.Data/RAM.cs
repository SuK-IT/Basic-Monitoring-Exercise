using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMonitor.Data
{
    public static class RAM
    {
        public static object[] GetRAMDisks()
        {
            throw new NotImplementedException();
        }

        public static RAMData GetRAMData(object RAMDisk)
        {
            throw new NotImplementedException();
        }

        public static RAMData[] GetAllRAMData()
        {
            throw new NotImplementedException();
        }
    }

    public class RAMData
    {
        public string DeviceName;
        public string HardwareId;
        public int UsedRAM;
        public int FreeRAM;
        public int TotalRAM
        {
            get 
            {
                return FreeRAM + UsedRAM;
            }
        }
    }
}
