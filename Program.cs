﻿using System;

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

        // Display the linked list
        linkedList.Display();
    }
}