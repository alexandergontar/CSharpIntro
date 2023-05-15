using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMI
{
    public class Disk
    {
        public string DiskName { get; set; }
        public UInt64 VolumeSize { get; set; }
        public UInt64 FreeSpace { get; set; }
    }
}
