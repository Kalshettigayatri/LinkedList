using System;
using System.Collections.Generic;

class StackOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stack Operations using LinkedList in C#");

        Stack<int> myStack = new Stack<int>();

        myStack.Push(56);
        myStack.Push(70);

        Console.WriteLine("Initial Sequence:");
        foreach (var item in myStack)
        {
            Console.Write(item + "->");
        }

        // Insert 30 between 56 and 70
        InsertBetween(myStack, 30, 56, 70);

        Console.WriteLine("\nFinal Sequence:");
        foreach (var item in myStack)
        {
            Console.Write(item + "->");
        }
    }

    static void InsertBetween<T>(Stack<T> stack, T valueToInsert, T valueAfter, T valueBefore)
    {
        Stack<T> tempStack = new Stack<T>();

        while (stack.Count > 0 && !stack.Peek().Equals(valueAfter))
        {
            tempStack.Push(stack.Pop());
        }

        stack.Push(valueAfter);
        stack.Push(valueToInsert);

        while (tempStack.Count > 0)
        {
            stack.Push(tempStack.Pop());
        }
    }
}
