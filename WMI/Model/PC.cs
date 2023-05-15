using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WMI.Model
{
    public class PC
    {
        public string PcInfo { get; set; }
        public List<Disk> Disks { get; set; }
        public List<string> PcItems { get; set; }
    }
}
