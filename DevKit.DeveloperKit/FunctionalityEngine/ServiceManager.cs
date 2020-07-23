using System.Data;

using AluminiumTech.PlatformKit;
using AluminiumTech.PlatformKit.enums;

namespace AluminiumTech.DevKit.DeveloperKit.FunctionalityEngine
{
    internal class ServiceManager
    {
        protected PlatformKit.Platform platform;
        protected PlatformKit.ProcessManager processManager;
        
        public ServiceManager()
        {
            platform = new Platform();
            processManager = new ProcessManager();
        }
        
        /// <summary>
        /// TODO: Complete this method.
        /// </summary>
        /// <param name="WindowsServiceName"></param>
        /// <param name="pathToServiceExe"></param>
        private void StartWindowsService(string WindowsServiceName, string pathToServiceExe)
        {
            if (true)
            //IsWindowsServiceRegistered())
            {
                
            }
            else
            {
                RegisterWindowsService(WindowsServiceName, pathToServiceExe);
                StartRegisteredWindowsService(WindowsServiceName);
            }
            
        }

        /*
        public bool IsWindowsServiceRegistered()
        {
            
        }
        */

        protected void RegisterWindowsService(string WindowsServiceName, string pathToServiceExe)
        {
            if (platform.ToEnum() == OperatingSystemFamily.Windows)
            {
                processManager.RunProcessWindows("powershell.exe", "sc.exe create " + WindowsServiceName + " binpath= " + pathToServiceExe  + " start= auto");
            }
        }

        protected void StartRegisteredWindowsService(string WindowsServiceName)
        {
            
        }

        protected void StopRegisteredWindowsService(string WindowsServiceName)
        {
            
        }
        
        protected void DeleteWindowsService(string WindowsServiceName)
        {
            StopRegisteredWindowsService(WindowsServiceName);
            if (platform.ToEnum() == OperatingSystemFamily.Windows)
            {
                processManager.RunProcessWindows("powershell.exe","sc.exe delete " + WindowsServiceName);
            }
        }
        
    }
}