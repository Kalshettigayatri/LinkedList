using System;

class Node<T> where T : IComparable<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

class SortedLinkedList<T> where T : IComparable<T>
{
    private Node<T> head;

    public void Add(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (head == null || head.Data.CompareTo(data) > 0)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null && current.Next.Data.CompareTo(data) < 0)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
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
}

class Program
{
    static void Main(string[] args)
    {
        SortedLinkedList<int> sortedList = new SortedLinkedList<int>();

        sortedList.Add(56);
        sortedList.Add(30);
        sortedList.Add(40);
        sortedList.Add(70);

        Console.WriteLine("Final Sequence:");
        sortedList.Display();
    }
}