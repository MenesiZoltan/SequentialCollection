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
            System.Console.WriteLine("HASHTABLE:---------------------\n");
            methods.WorkingWithHashtable("1, 2, 3, 4");
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

        public void WorkingWithHashtable(string testVariable)
        {
            Hashtable table = new Hashtable();
            table.Add("1", "one");
            table.Add("2", "two");
            table.Add("3", "three");
            table.Add("4", "four");
            table.Add("5", "five");
            table.Add("6", "six");
            table.Add("7", "seven");
            table.Add("8", "eight");
            table.Add("9", "nine");
            table.Add("10", "ten");

            foreach (var letter in testVariable)
            {
                string temp = letter.ToString();
                if (table.Contains(temp)) 
                {
                    System.Console.WriteLine($"This is in the has table! Key is {temp} and value is {table[temp]}!");
                }
            }
        }
    }
}
