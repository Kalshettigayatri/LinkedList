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
    public Node<T> Head { get; private set; }

    public void Append(T data)
    {
        Node<T> newNode = new Node<T>(data);

        if (Head == null)
        {
            Head = newNode;
        }
        else
        {
            Node<T> current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public Node<T> Search(T key)
    {
        Node<T> current = Head;
        while (current != null)
        {
            if (current.Data.Equals(key))
            {
                return current;
            }
            current = current.Next;
        }
        return null; // Node with the given key not found
    }

    public void InsertAfter(Node<T> node, T data)
    {
        if (node == null)
        {
            throw new ArgumentNullException(nameof(node));
        }

        Node<T> newNode = new Node<T>(data);
        newNode.Next = node.Next;
        node.Next = newNode;
    }

    public void Display()
    {
        Node<T> current = Head;
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

        linkedList.Append(56);
        linkedList.Append(30);
        linkedList.Append(70);

        Console.WriteLine("Initial Sequence:");
        linkedList.Display();

        Node<int> nodeToInsertAfter = linkedList.Search(30);
        if (nodeToInsertAfter != null)
        {
            linkedList.InsertAfter(nodeToInsertAfter, 40);
            Console.WriteLine("\nFinal Sequence after inserting 40 after 30:");
            linkedList.Display();
        }
        else
        {
            Console.WriteLine("Node with value 30 not found.");
        }
    }
}