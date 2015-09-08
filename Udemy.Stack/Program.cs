using System;

namespace Udemy.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var stack = new Stack();
                stack.Push(1);
                stack.Push(2);
                //stack.Push(null);

                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
                Console.WriteLine(stack.Pop());
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("inavlid opeartion");
            }

            Console.ReadLine();
        }
    }
}
