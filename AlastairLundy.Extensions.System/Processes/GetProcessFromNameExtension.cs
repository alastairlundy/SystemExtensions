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

using System;
using System.Diagnostics;

namespace AlastairLundy.Extensions.System.Processes;

    public static class GetProcessFromNameExtension
    {
        /// <summary>
        /// Retrieves the Process object with the same name as the specified string.
        /// </summary>
        /// <param name="process">The process object</param>
        /// <param name="processName">The name of the process to be retrieved.</param>
        /// <returns>the Process object with the same name as the specified string.</returns>
        public static Process GetProcessFromName(this Process process, string processName)
        {

            if (processName.Contains(".app"))
            {
                processName = processName.Replace(".app", string.Empty);
            }

            if (process.IsProcessRunning(processName) ||
                process.IsProcessRunning(processName.ToLower()) ||
                process.IsProcessRunning(processName.ToUpper()))
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

            throw new ArgumentException();
        }
    }