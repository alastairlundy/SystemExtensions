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

             foreach (Action action in actionQueue)
             {
                 listOfTasks.Add(new Task(action));
             }

             Task[] tasks = listOfTasks.ToArray();

             for (int index = 0; index < tasks.Length; index++)
             {
                 tasks[index].Start();
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
                     if (pair.Value.Equals(PriorityLevel.EmergencyPriority))
                     {
                         actionsQueue.Enqueue(pair.Key);
                     }
                 }

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

        protected DateTime TimeSpanToDateTime(TimeSpan delay)
        {
            DateTime functionExecutionTime = DateTime.UtcNow;
            functionExecutionTime = functionExecutionTime.Add(delay);
            return functionExecutionTime;
        }
        
        public void DelayExecutionOfFunction(Action action, TimeSpan delay)
        {
            DelayExecutionOfFunction(action, TimeSpanToDateTime(delay));
        }

        public void DelayExecutionOfFunction(Action action, DateTime date)
        { 
            DelayExecutionofFunction(action, date).Start();
            DelayExecutionofFunction(action, date).Wait();
        }

        public async Task DelayExecutionofFunction(Action action, DateTime date)
        {
            await Task.Delay(date.TimeOfDay);
            action.Invoke();
        }
    }
}