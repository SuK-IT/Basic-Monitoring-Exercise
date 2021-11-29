using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMonitor.Data
{
    public static class Disk
    {
        public static object GetDisks()
        {
            throw new NotImplementedException();
        }

        public static DiskData GetDataForDisk(object Disk)
        {
            throw new NotImplementedException();
        }

        public static DiskData[] GetAllDisksData()
        {
            throw new NotImplementedException();
        }
    }

    public class DiskData
    {
        public string DeviceName;
        public string HardwareId;
        public int FreeStorage;
        public int UsedStorage;

        public int TotalStorage
        {
            get
            {
                return FreeStorage + UsedStorage;
            }
        }

        public DiskData(string DeviceName, string HardwareId, int FreeStorage, int UsedStorage)
        {
            this.DeviceName = DeviceName;
            this.HardwareId = HardwareId;
            this.FreeStorage = FreeStorage;
            this.UsedStorage = UsedStorage;
        }
    }
}
