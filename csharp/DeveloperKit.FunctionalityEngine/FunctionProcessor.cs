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
using System.Threading.Tasks;
using AluminiumTech.DevKit.DeveloperKit.FunctionalityEngine.enums;

// ReSharper disable All

namespace AluminiumTech.DevKit.DeveloperKit.FunctionalityEngine
{
    public class FunctionProcessor
    {
        public FunctionProcessor()
        {
            
        }
        
        public void ExecuteFunctionsInOrderOfPriorityInTasks(List<KeyValuePair<Action, PriorityLevel>> listOfActionsAndPriorities)
        {
             Queue<Action> actionQueue = CreateQueueOfActionsBasedOnPriorities(listOfActionsAndPriorities);

             List<Task> listOfTasks = new List<Task>();

             foreach (var action in actionQueue)
             {
                 listOfTasks.Add(new Task(action));
             }

             var tasks = listOfTasks.ToArray();

             foreach (var task in tasks)
             {
                 task.Start();
             }
             
             Task.WaitAll(tasks);
        }

        public Queue<Action> CreateQueueOfActionsBasedOnPriorities(
             List<KeyValuePair<Action, PriorityLevel>> listOfActionsAndPriorities)
        {
             Queue<Action> actionsQueue = new Queue<Action>();

             foreach (KeyValuePair<Action, PriorityLevel> pair in listOfActionsAndPriorities)
             {
                 for (int index = 0; index < listOfActionsAndPriorities.Count; index++)
                 {
                     if (pair.Value.Equals(PriorityLevel.HighPriority))
                     {
                         actionsQueue.Enqueue(pair.Key);
                     }
                 }

                 for (int index = 0; index < listOfActionsAndPriorities.Count; index++)
                 {
                     if (pair.Value.Equals(PriorityLevel.MediumPriority))
                     {
                         actionsQueue.Enqueue(pair.Key);
                     }
                 }

                 for (int index = 0; index < listOfActionsAndPriorities.Count; index++)
                 {
                     if (pair.Value.Equals(PriorityLevel.LowPriority))
                     {
                         actionsQueue.Enqueue(pair.Key);
                     }
                 }
             }

             return actionsQueue;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delay"></param>
        /// <returns></returns>
        public DateTime TimeSpanToDateTime(TimeSpan delay)
        {
            DateTime functionExecutionTime = DateTime.UtcNow;
            functionExecutionTime = functionExecutionTime.Add(delay);
            return functionExecutionTime;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="delay"></param>
        public void DelayExecutionOfFunction(Action action, TimeSpan delay)
        {
            DelayExecutionOfFunction(action, TimeSpanToDateTime(delay));
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="date"></param>
        public void DelayExecutionOfFunction(Action action, DateTime date)
        { 
            DelayExecutionOfFunctionTask(action, date).Start();
            DelayExecutionOfFunctionTask(action, date).Wait();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="action"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public async Task DelayExecutionOfFunctionTask(Action action, DateTime date)
        {
            await Task.Delay(date.TimeOfDay);
            action.Invoke();
        }
    }
}