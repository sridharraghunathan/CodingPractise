using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class DS
    {
        public void InBuiltDataStructure()
        {

            var names = new LinkedList<string>();
            names.AddLast("Sonoo");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            LinkedListNode<string> nameNode = names.FindLast("Sonoo");

            names.AddBefore(nameNode, "Sri");
            names.AddAfter(nameNode, "Sri1");
            names.AddLast("Final");
            names.AddFirst("Super");
            /*
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            */
            names.Reverse();


            var number = new LinkedList<int>();
            number.AddFirst(1);
            number.AddLast(2);
            number.AddLast(3);
            foreach (var num in number)
            {
                Console.WriteLine(num);
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();

            SortedDictionary<string, string> namesSorted = new SortedDictionary<string, string>();
            namesSorted.Add("1", "Sonoo");
            namesSorted.Add("4", "Peter");
            namesSorted.Add("5", "James");
            namesSorted.Add("3", "Ratan");
            namesSorted.Add("2", "Irfan");


            Queue<string> namesQueue = new Queue<string>();
            namesQueue.Enqueue("Sonoo");
            namesQueue.Enqueue("Peter");
            namesQueue.Enqueue("James");
            namesQueue.Enqueue("Ratan");
            namesQueue.Enqueue("Irfan");

            foreach (string name in namesQueue)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + namesQueue.Peek());
            Console.WriteLine("Dequeue: " + namesQueue.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + namesQueue.Peek());
        }
    }

}
