using System;
using System.Management;
using System.Collections.Generic;
using WMI.Model;
using WMI.Services;

namespace WMI
{
    class Program
    {
        static void Main(string[] args)
        {
            CompInfo info = new CompInfo();
            info.GetInfo();
    
        }
    }
}
