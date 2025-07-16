using System;
using System.Collections.Generic;
namespace AdvancedExercises
{
    class Stack
    {
        private List<object> objectList = new List<object>();
        public void Push(object obj)
        {
            objectList.Add(obj);
        }
        public void PrintStack()
        {
            foreach (object obj in objectList)
            {
                Console.WriteLine(obj);
            }
        }
        public void Pop()
        {
            objectList.RemoveAt(objectList.Count - 1);
        }
    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Pop();
            stack.PrintStack();
        }
    }
}