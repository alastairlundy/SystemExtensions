/*
        MIT License
       
       Copyright (c) 2020-2024 Alastair Lundy
       
       Permission is hereby granted, free of charge, to any person obtaining a copy
       of this software and associated documentation files (the "Software"), to deal
       in the Software without restriction, including without limitation the rights
       to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
       copies of the Software, and to permit persons to whom the Software is
       furnished to do so, subject to the following conditions:
       
       The above copyright notice and this permission notice shall be included in all
       copies or substantial portions of the Software.
       
       THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
       IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
       FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
       AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
       LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
       OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
       SOFTWARE.
   */

using System.Diagnostics;

namespace AlastairLundy.System.Extensions.ProcessExtensions
{
    public static class GetProcessFromProcessNameExtension
    {
        /// <summary>
        /// Converts a String to a Process
        /// </summary>
        /// <param name="process"></param>
        /// <param name="processName"></param>
        /// <returns></returns>
        public static Process GetProcessFromProcessName(this Process process, string processName)
        {
            processName = processName.Replace(".exe", string.Empty);

            if (process.IsProcessRunning(processName) ||
                process.IsProcessRunning(processName.ToLower()) ||
                process.IsProcessRunning(processName.ToUpper())
               )
            {
                Process[] processes = Process.GetProcesses();

                foreach (Process p in processes)
                {
                    if (p.ProcessName.ToLower().Equals(processName.ToLower()))
                    {
                        return p;
                    }
                }
            }

            return null;
            //  throw new Exception();
        }
    }
}