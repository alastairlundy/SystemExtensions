/*
    DeveloperKit
    Copyright (C) 2021 AluminiumTech

    This library is free software; you can redistribute it and/or
    modify it under the terms of the GNU Lesser General Public
    License as published by the Free Software Foundation; either
    version 2.1 of the License, or (at your option) any later version.

    This library is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
    Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public
    License along with this library; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
    USA
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