using System;
using System.Management;
using System.Collections.Generic;
using WMI.Model;
using WMI.Services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WMI
{
    class Program
    {
      
        static void Main(string[] args)
        {            
            new BL(new WebAPIClient(),
                     new CompInfo())
                      .Run();
        }
    }
}
