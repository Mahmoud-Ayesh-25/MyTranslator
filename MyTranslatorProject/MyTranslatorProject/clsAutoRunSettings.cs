using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyTranslatorProject
{
    public class clsAutoRunSettings
    {
        static readonly string registryPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        public static void EnableStartup(string appName)
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            if (!File.Exists(exePath)) return;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
                key?.SetValue(appName, exePath);
        }

        public static void DisableStartup(string appName)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, true))
                if (key?.GetValue(appName) != null)
                    key.DeleteValue(appName);
        }

        public static bool IsStartupEnabled(string appName)
        {
            string exePath = Assembly.GetExecutingAssembly().Location;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(registryPath, false))
            {
                object value = key?.GetValue(appName);
                return value != null && value.ToString() == exePath;
            }
        }
    }
}
