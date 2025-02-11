using System;

public class LinkedListStack<T>
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

    private Node top;

    public LinkedListStack()
    {
        top = null;
    }

    public void Push(T item)
    {
        Node newNode = new Node(item);
        newNode.Next = top;
        top = newNode;
    }

    public T Pop()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Pop from an empty stack");
        }
        T item = top.Data;
        top = top.Next;
        return item;
    }
}