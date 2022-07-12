/* BSD 3-Clause License
    
    Copyright (c) 2020-2021, AluminiumTech DevKit
    All rights reserved.
    
    Redistribution and use in source and binary forms, with or without
    modification, are permitted provided that the following conditions are met:
    
    1. Redistributions of source code must retain the above copyright notice, this
       list of conditions and the following disclaimer.
    
    2. Redistributions in binary form must reproduce the above copyright notice,
       this list of conditions and the following disclaimer in the documentation
       and/or other materials provided with the distribution.
    
    3. Neither the name of the copyright holder nor the names of its
       contributors may be used to endorse or promote products derived from
       this software without specific prior written permission.
    
    THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
    AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
    IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
    DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE
    FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
    DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
    SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
    CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
    OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
    OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
    */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using AluminiumTech.DeveloperKit.Exceptions;

namespace AluminiumTech.DeveloperKit.ConsoleHelpers
{
    public class ConsoleHelpMessageBuilder
    {
        protected string CallingProgramFriendlyName;
        protected bool OverrideCallingProgramAssemblyName;

        public bool UsageRegistered = false;
        
        public ConsoleHelpMessageBuilder(string callingProgramFriendlyName, bool overrideCallingProgramAssemblyName)
        {
            CallingProgramFriendlyName = callingProgramFriendlyName;
            OverrideCallingProgramAssemblyName = overrideCallingProgramAssemblyName;
        }

        private List<string> text = new List<string>();

        /// <summary>
        /// Registers that you use a Help Message.
        /// </summary>
        /// <param name="usageArgs"></param>
        public void RegisterUsage(string[] usageArgs)
        {
            var assembly = FileVersionInfo.GetVersionInfo(Assembly.GetCallingAssembly().Location);
            
            if (!OverrideCallingProgramAssemblyName)
            {
                CallingProgramFriendlyName = Assembly.GetCallingAssembly().GetName().Name;
            }
            
            text.Add($"{CallingProgramFriendlyName} {assembly.LegalCopyright} {assembly.CompanyName}");
            text.Add("\n");
            text.Add("\n");
            
            string usage = CallingProgramFriendlyName;

            foreach (var arg in usageArgs)
            {
                usage += " [" + arg + "]";
            }
            
            text.Add(usage);
            UsageRegistered = true;
        }

        public void AddSection(string sectionName)
        {
            text.Add("\n");
            text.Add("\n");
            text.Add(sectionName);
            text.Add("\n");
            AddOptionHeader("Short Option:", "Long Option:", "Description:");
        }
        
        /// <summary>
        /// Adds information for a command
        /// </summary>
        /// <param name="shortOption">The shorthand for a command. Don't include "-" in string. E.g. for -h enter h.</param>
        /// <param name="longOption">The longhand for a command. Don't include "--" in string. E.g. for --help enter help.</param>
        /// <param name="optionDescription">The description for a command. E.g. Displays app help information.</param>
        public void AddOption(string shortOption, string longOption, string optionDescription)
        {
            try
            {
                if (UsageRegistered)
                {
                    if (shortOption == null || longOption == null || optionDescription == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        AddOptionHeader("-" + shortOption, "--" + longOption, optionDescription);
                    }
                }
                else if(!UsageRegistered)
                {
                    throw new ConsoleHelpMessageUsageRegistrationException();
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
                throw new Exception(exception.ToString());
            }
        }

        protected void AddOptionHeader(string shortOption, string longOption, string optionDescription)
        {
            try
            {
                if (UsageRegistered)
                {
                    if (shortOption == null || longOption == null || optionDescription == null)
                    {
                        throw new ArgumentNullException();
                    }
                    else
                    {
                        string command = $"{shortOption}       {longOption}       {optionDescription}";
                        text.Add(command);
                    }
                }
                else if(!UsageRegistered)
                {
                    throw new ConsoleHelpMessageUsageRegistrationException();
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
                throw new Exception(exception.ToString());
            }
        }

        public void PrintHelpMessages()
        {
            try
            {
                if (text.Count > 0 && UsageRegistered)
                {
                    foreach (var line in text)
                    {
                        Console.WriteLine(line);
                    }
                }
                else if (UsageRegistered)
                {
                    throw new ConsoleHelpMessageUsageRegistrationException();
                }
                else if (text.Count == 0 || text.Count == 1)
                {
                    throw new NullReferenceException();
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception);
                throw new Exception(exception.ToString());
            }
        }
    }
}