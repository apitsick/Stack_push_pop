using System;

public class ArrayStack<T>
{
    private T[] stack;
    private int top;
    private int maxSize;

    public ArrayStack(int maxSize)
    {
        this.maxSize = maxSize;
        stack = new T[maxSize];
        top = -1;
    }

    public void Push(T item)
    {
        if (top >= maxSize - 1)
        {
            throw new InvalidOperationException("Stack is full");
        }
        stack[++top] = item;
    }

    public T Pop()
    {
        if (top < 0)
        {
            throw new InvalidOperationException("Pop from an empty stack");
        }
        return stack[top--];
    }
}
