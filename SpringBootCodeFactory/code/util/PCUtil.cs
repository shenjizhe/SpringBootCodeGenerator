using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Management.Instrumentation;

namespace SpringBootCodeFactory.code.util
{
    public static class PCUtil
    {
        /// 
        /// 获得CPU编号
        /// 
        public static string GetCPUID()
        {
            string cpuid = "";
            ManagementClass mc = new ManagementClass("Win32_Processor");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                cpuid += mo.Properties["ProcessorId"].Value.ToString() + "\n";
            }
            return cpuid;
        }
        /// 
        /// 获取硬盘序列号
        /// 
        public static string GetDiskSerialNumber()
        {
            //这种模式在插入一个U盘后可能会有不同的结果，如插入我的手机时
            String HDid = "";
            ManagementClass mc = new ManagementClass("Win32_DiskDrive");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                HDid += (string)mo.Properties["SerialNumber"].Value + "\n";//SerialNumber在Win7以上系统有效
                //break;//这名话解决有多个物理盘时产生的问题，只取第一个物理硬盘，也可查wmi_HD["MediaType"].ToString() == "Fixed hard disk media")//固定硬盘，在Win7以上系统上，XP上"Fixed hard disk ”
            }
            return HDid;


        }
        /// 
        /// 获取网卡硬件地址
        /// 
        public static string GetMacAddress()
        {
            string mac = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    mac += mo["MacAddress"].ToString() + "\n";
                }
            }
            return mac;
        }

        /// 
        /// 获取IP地址
        /// 
        public static string GetIPAddress()
        {
            string st = "";
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                if ((bool)mo["IPEnabled"] == true)
                {
                    //st=mo["IpAddress"].ToString(); 
                    System.Array ar;
                    ar = (System.Array)(mo.Properties["IpAddress"].Value);
                    st += ar.GetValue(0).ToString();
                }
            }
            return st;
        }
        /// 
        /// 操作系统的登录用户名
        /// 
        public static string GetUserName()
        {
            return Environment.UserName;
        }

        /// 
        /// 获取计算机名
        /// 
        public static string GetComputerName()
        {
            return Environment.MachineName;
        }
        /// 
        /// 操作系统类型
        /// 
        public static string GetSystemType()
        {
            string st = "";
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                st += mo["SystemType"].ToString();
            }
            return st;
        }
        /// 
        /// 物理内存
        /// 
        public static string GetPhysicalMemory()
        {
            string st = "";
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject mo in moc)
            {
                st += mo["TotalPhysicalMemory"].ToString();
            }
            return st;
        }

    }
}
