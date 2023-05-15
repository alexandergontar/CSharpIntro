using System;
using System.Management;
using System.Collections.Generic;
using WMI.Model;
using WMI.Services;
using Newtonsoft.Json;

namespace WMI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CompInfo info = new CompInfo();
            PC pc = info.GetInfo();
            string output = JsonConvert.SerializeObject(pc);
            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
