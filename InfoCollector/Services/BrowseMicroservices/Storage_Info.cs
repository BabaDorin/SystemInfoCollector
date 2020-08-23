﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoCollector.Models;
using System.Management;
using System.IO;
using System.Diagnostics;

namespace InfoCollector.Services
{
    class Storage_Info
    {
        //private static ManagementObjectSearcher DriveSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMedia");
        private static ManagementObjectSearcher DriveSearcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_DiskDrive");

        public static Storage Info()
        {
            Storage storage = new Storage
            {
                NumberOfStorageDevices = DriveSearcher.Get().Count,
            };

            try
            {
                foreach (ManagementObject queryObj in DriveSearcher.Get())
                {
                    StorageDevice storageDevice = new StorageDevice();
                    storageDevice.DeviceId = queryObj["DeviceID"].ToString();
                    storageDevice.Capacity = queryObj["Size"].ToString();
                    storageDevice.Manufacturer =  queryObj["Manufacturer"].ToString();
                    storageDevice.SerialNumber =  queryObj["SerialNumber"].ToString();
                    storageDevice.Type = queryObj["MediaType"].ToString();
                    Debug.WriteLine(queryObj.ToString());
                    storage.StorageDevices.Add(storageDevice);
                }
            }
            catch (Exception)
            {
                Debug.Write("Error");
            }

            return storage;
        }
    }
}
