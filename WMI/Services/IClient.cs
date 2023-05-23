using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMI.Services
{
    public interface IClient
    {
        public  Task<string> sendPost(string output, string url);
    }
}
