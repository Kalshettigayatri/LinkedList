using System;

class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList<T>
{
    private Node<T> head;

    public void Append(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public void Display()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.Write(current.Data + "->");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void PopLast()
    {
        if (head == null)
        {
            throw new InvalidOperationException("LinkedList is empty");
        }
        else if (head.Next == null)
        {
            head = null;
        }
        else
        {
            Node<T> current = head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        // Append values to the linked list in the specified sequence
        linkedList.Append(56);
        linkedList.Append(30);
        linkedList.Append(70);

        Console.WriteLine("Initial Sequence:");
        linkedList.Display();

        linkedList.PopLast();

        Console.WriteLine("\nSequence after popping the last element:");
        linkedList.Display();
    }
}