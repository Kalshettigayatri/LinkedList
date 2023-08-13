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

    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            newNode.Next = head;
            head = newNode;
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
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        // Add values to the linked list in the specified sequence
        linkedList.Add(70);
        linkedList.Add(30);
        linkedList.Add(56);

        // Display the linked list
        linkedList.Display();
    }
}