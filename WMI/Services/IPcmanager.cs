using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMI.Model;

namespace WMI.Services
{
    public interface IPcmanager
    {
        public PC GetInfo();
    }
}
