using System.Collections;
using CollectionExcercises;

namespace SequentialCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethods methods = new myMethods();
            System.Console.WriteLine("QUEUE:---------------------\n");
            methods.WorkingWithQueue();
            System.Console.WriteLine("STACK:---------------------\n");
            methods.WorkingWithStack();
            System.Console.ReadLine();
        }
    }
}

namespace CollectionExcercises
{
    class myMethods
    {
        public void WorkingWithQueue()
        {
            Queue testQueue = new Queue();
            testQueue.Enqueue("First");
            testQueue.Enqueue("Second");
            testQueue.Enqueue("Third");
            testQueue.Enqueue("Fourth");

            while (testQueue.Count != 0)
            {
                System.Console.WriteLine("\n");
                foreach (string item in testQueue)
                {
                    System.Console.WriteLine($"Current item is: {item}");
                }

                testQueue.Dequeue();
            }
        }

        public void WorkingWithStack()
        {
            Stack stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            while (stack.Count != 0)
            {
                System.Console.WriteLine("\n");
                foreach (string item in stack)
                {
                    System.Console.WriteLine($"Current item is: {item}");
                }

                stack.Pop();
            }
        }
    }
}
