using System.Collections;
using CollectionExcercises;

namespace SequentialCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethods methods = new myMethods();
            methods.WorkingWithQueue();


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
            System.Console.ReadLine();
        }
    }
}
