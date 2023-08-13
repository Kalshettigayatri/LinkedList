using System;

class LinkedList<T>
{
    public class Node
    {
        public T Value { get; set; }
        public Node Next { get; set; }
    }

    private Node head;

    public void Add(T value)
    {
        Node newNode = new Node { Value = value, Next = head };
        head = newNode;
    }

    public void Pop()
    {
        if (head != null)
        {
            head = head.Next;
        }
    }

    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Value);
            if (current.Next != null)
            {
                Console.Write("->");
            }
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class LinkedListOperations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Linked List Operations using Generics in C#");

        LinkedList<int> myList = new LinkedList<int>();
        myList.Add(70);
        myList.Add(30);
        myList.Add(56);

        Console.WriteLine("Initial Sequence:");
        myList.Display();

        myList.Pop();

        Console.WriteLine("Final Sequence:");
        myList.Display();
    }
}
