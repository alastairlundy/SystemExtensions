/*
MIT License

Copyright (c) AluminiumTech 2018-2020

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
using System.Collections.Generic;
using System.Threading.Tasks;

using AluminiumTech.DevKit.DeveloperKit.enums;
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