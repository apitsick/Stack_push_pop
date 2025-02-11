using System;

public class ArrayQueue<T>
{
    private T[] queue;
    private int front;
    private int rear;
    private int count;
    private int maxSize;

    public ArrayQueue(int maxSize)
    {
        this.maxSize = maxSize;
        queue = new T[maxSize];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == maxSize)
        {
            throw new InvalidOperationException("Queue is full");
        }
        rear = (rear + 1) % maxSize;
        queue[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Dequeue from an empty queue");
        }
        T item = queue[front];
        front = (front + 1) % maxSize;
        count--;
        return item;
    }
}