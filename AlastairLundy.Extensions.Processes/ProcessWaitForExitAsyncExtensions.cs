/*
        MIT License
       
       Copyright (c) 2024 Alastair Lundy
       
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
using System.Threading;
using System.Threading.Tasks;

namespace AlastairLundy.Extensions.Processes
{
    public static class ProcessWaitForExitAsyncExtensions
    {

#if NETSTANDARD2_0 || NETSTANDARD2_1
        /// <summary>
        /// Asynchronously await for a process to exit.
        /// </summary>
        /// <param name="process">The process to await the exit of.</param>
        /// <param name="cancellationToken">The cancellation token to be propogated in case cancellation is requested.</param>
        public static async Task WaitForExitAsync(this Process process,
            CancellationToken cancellationToken = default)
        {
            if (process.IsProcessRunning(process.ProcessName) == false)
            {
                process.Start();
            }
        
            var task = new Task(process.WaitForExit);
        
            task.Start();

            await task.ConfigureAwait(true);
        }
    
        /// <summary>
        /// Asynchronously await for either a process to exit or for the timeout to be exceeded, whichever is sooner.
        /// </summary>
        /// <param name="process">The process to await the exit of.</param>
        /// <param name="timeoutMilliseconds">The milliseconds to wait before timing out.</param>
        /// <param name="cancellationToken">The cancellation token to be propogated in case cancellation is requested.</param>
        public static async Task WaitForExitAsync(this Process process, int timeoutMilliseconds = Timeout.Infinite,
            CancellationToken cancellationToken = default)
        {
            if (process.IsProcessRunning(process.ProcessName) == false)
            {
                process.Start();
            }
        
            var task = new Task(() =>
            {  
                process.WaitForExit(timeoutMilliseconds);
            });
        
            task.Start();
        
            await Task.WhenAny(task, Task.Delay(timeoutMilliseconds, cancellationToken));
        }
#endif
    }
}