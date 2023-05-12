using System;
using System.Text;
using System.Threading;
using Microsoft.Management.Infrastructure;
using Microsoft.Management.Infrastructure.Options;
using System.Security;
using System.Management;
using System.Collections.Generic;

namespace WMI
{
    class Program
    {

        
        static void Main(string[] args)
        {
            //ConnectionOptions connection = new ConnectionOptions();
            //connection.Username = "cstgontaa";
            //connection.Password = "N@talie-1917";
            // connection.Authority = "";
            // Build an options object for the remote connection
            // if you plan to connect to the remote
            // computer with a different user name
            // and password than the one you are currently using.
            // This example uses the default values.
            try
            {
 ConnectionOptions options =
                new ConnectionOptions();
            //options.Username = "Alexander";
            //options.Password = "12345";
            //options.EnablePrivileges = true;
            //options.Authority = "ntlmdomain:WORKGROUP";
            //options.Authentication = AuthenticationLevel.Default;
            options.Impersonation = ImpersonationLevel.Impersonate;

            // Make a connection to a remote computer.
            // Replace the "FullComputerName" section of the
            // string "\\\\FullComputerName\\root\\cimv2" with
            // the full computer name or IP address of the
            // remote computer.
            ManagementScope scope =
                new ManagementScope(
                "\\\\localhost\\root\\cimv2", options);
            scope.Connect();




            
            //Query system for Operating System information
            ObjectQuery query = new ObjectQuery(
                "SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(scope, query);

            ManagementObjectCollection queryCollection = searcher.Get();
            foreach (ManagementObject m in queryCollection)
            {
                // Display the remote computer information
                Console.WriteLine("Computer Name : {0}",
                    m["csname"]);
              string compName = String.Format("Computer Name : {0}", m["csname"]);
                Console.WriteLine("Windows Directory : {0}",
                    m["WindowsDirectory"]);
                Console.WriteLine("Operating System: {0}",
                    m["Caption"]);
                Console.WriteLine("Version: {0}", m["Version"]);
                Console.WriteLine("Manufacturer : {0}",
                    m["Manufacturer"]);
            }
            

             query = new ObjectQuery("SELECT * FROM Win32_LogicalDisk");

             searcher = new ManagementObjectSearcher(scope, query);

            foreach (ManagementObject managementObject in searcher.Get())
            {
                Console.WriteLine("Drive Name :" +
                                   managementObject["Name"].ToString());
                Console.WriteLine("Volume Size :" +
                                   managementObject["Size"].ToString());
                Console.WriteLine("Free Space :" +
                                   managementObject["FreeSpace"].ToString());
            }

            Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                Console.ReadKey();
            }
           
        }
    }
}
