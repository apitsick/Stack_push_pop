using System;

public class LinkedListQueue<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node front;
    private Node rear;

    public LinkedListQueue()
    {
        front = null;
        rear = null;
    }

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (rear == null)
        {
            front = newNode;
            rear = newNode;
        }
        else
        {
            rear.Next = newNode;
            rear = newNode;
        }
    }

    public T Dequeue()
    {
        if (front == null)
        {
            throw new InvalidOperationException("Dequeue from an empty queue");
        }
        T item = front.Data;
        front = front.Next;
        if (front == null)
        {
            rear = null;
        }
        return item;
    }
}