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
        static async Task<string> sendPost(string output) 
        {
            var data = new StringContent(output, Encoding.UTF8, "application/json");
            var url = "https://httpbin.org/post";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);
            return result;
        }
        static  void Main(string[] args)
        {
            //var http = new HttpClient();
            CompInfo info = new CompInfo();
            PC pc = info.GetInfo();
            string output = JsonConvert.SerializeObject(pc);
            PC pc1 = JsonConvert.DeserializeObject<PC>(output);
            foreach (Disk disk in pc1.Disks)
            {
                Console.WriteLine("{0}   {1}   {2}",
                    disk.DiskName, disk.VolumeSize, disk.FreeSpace);
            }

            Console.WriteLine("\n ===== JSON Format ===== :");
            Console.WriteLine(output);


            /*var data = new StringContent(output, Encoding.UTF8, "application/json");
            var url = "https://httpbin.org/post";
            using var client = new HttpClient();

            var response = await client.PostAsync(url, data);

            var result = await response.Content.ReadAsStringAsync();
            Console.WriteLine(result);*/
             Task<string> result = sendPost(output);
            result.Wait();
            //await result;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
