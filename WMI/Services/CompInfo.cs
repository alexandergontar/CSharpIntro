﻿using System;
using System.Management;
using System.Collections.Generic;
using WMI.Model;

namespace WMI.Services
{
    public class CompInfo
    {

        public PC GetInfo() 
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
            List<Disk> disks = new List<Disk>();
            List<string> commonInfo = new List<string>();
            string compInfo =String.Empty;
            PC pc = new PC();
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
                    Console.WriteLine("Computer Name : {0}", m["csname"]);                   
                    commonInfo.Add(String.Format("Computer Name : {0}\n", m["csname"]));
                    Console.WriteLine("Windows Directory : {0}", m["WindowsDirectory"]);
                    commonInfo.Add(String.Format("Windows Directory : {0}\n", m["WindowsDirectory"]));
                    Console.WriteLine("Operating System: {0}", m["Caption"]);
                    commonInfo.Add(String.Format("Operating System: {0}\n", m["Caption"]));
                    Console.WriteLine("Version: {0}", m["Version"]);
                    commonInfo.Add(String.Format("Version: {0}\n", m["Version"]));
                    Console.WriteLine("Manufacturer : {0}", m["Manufacturer"]);
                    commonInfo.Add(String.Format("Manufacturer : {0}\n", m["Manufacturer"]));
                }   


                query = new ObjectQuery("SELECT * FROM Win32_LogicalDisk");

                searcher = new ManagementObjectSearcher(scope, query);


                foreach (ManagementObject managementObject in searcher.Get())
                {
                    Disk disk = new Disk();
                    Console.WriteLine("Drive Name :" +
                                       managementObject["Name"].ToString());
                    disk.DiskName = managementObject["Name"].ToString();
                    Console.WriteLine("Volume Size :" +
                                       managementObject["Size"].ToString());
                    disk.VolumeSize = (UInt64)managementObject["Size"];
                    Console.WriteLine("Free Space :" +
                                       managementObject["FreeSpace"].ToString());
                    disk.FreeSpace = (UInt64)managementObject["FreeSpace"];
                    disks.Add(disk);
                }
                foreach (Disk d in disks)
                {
                    Console.WriteLine($"{d.DiskName}  {d.VolumeSize}  {d.FreeSpace}");
                }
                foreach (string item in commonInfo)
                {
                    Console.WriteLine(item);
                    compInfo += item;
                }
                Console.Write(compInfo);
                pc.Disks = disks;
                pc.PcInfo = compInfo;
                pc.PcItems = commonInfo;
                Console.ReadKey();
                return pc;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
                foreach (Disk d in disks)
                {
                    Console.WriteLine($"{d.DiskName}  {d.VolumeSize}  {d.FreeSpace}");
                }
                foreach (string item in commonInfo)
                {
                    Console.WriteLine(item);
                    compInfo += item;
                }
                Console.Write(compInfo);
                pc.Disks = disks;
                pc.PcInfo = compInfo;
                pc.PcItems = commonInfo;
                Console.ReadKey();
                return pc;
            }
        }

    }
}
