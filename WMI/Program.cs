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
            IPcmanager info = new CompInfo();
            PC pc = info.GetInfo();
            string output = JsonConvert.SerializeObject(pc);
            // Test Deserialization
            /*PC pc1 = JsonConvert.DeserializeObject<PC>(output);
            foreach (Disk disk in pc1.Disks)
            {
                Console.WriteLine("{0}   {1}   {2}",
                    disk.DiskName, disk.VolumeSize, disk.FreeSpace);
            }*/
            Console.WriteLine("\n ===== JSON Format ===== :");
            Console.WriteLine(output);

            IClient client = new WebAPIClient();            
            Task<string> result = client.sendPost(output);
            result.Wait();
            Console.WriteLine(result.Result.ToString());
            Console.ReadKey();
        }
    }
}
