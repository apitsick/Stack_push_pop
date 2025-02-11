using System;
using System.Diagnostics;

public class PerformanceTests
{
    public static void Main()
    {
        int[] operationCounts = { 100, 1000, 10000, 100000 };

        // Тестування стеку на основі масиву
        Console.WriteLine("ArrayStack performance:");
        foreach (int count in operationCounts)
        {
            var arrayStack = new ArrayStack<int>(count);
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++) arrayStack.Push(i);
            for (int i = 0; i < count; i++) arrayStack.Pop();
            stopwatch.Stop();
            Console.WriteLine($"{count} operations: {stopwatch.ElapsedMilliseconds} ms");
        }

        // Тестування стеку на основі зв'язного списку
        Console.WriteLine("LinkedListStack performance:");
        foreach (int count in operationCounts)
        {
            var linkedListStack = new LinkedListStack<int>();
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++) linkedListStack.Push(i);
            for (int i = 0; i < count; i++) linkedListStack.Pop();
            stopwatch.Stop();
            Console.WriteLine($"{count} operations: {stopwatch.ElapsedMilliseconds} ms");
        }

        // Тестування черги на основі масиву
        Console.WriteLine("ArrayQueue performance:");
        foreach (int count in operationCounts)
        {
            var arrayQueue = new ArrayQueue<int>(count);
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++) arrayQueue.Enqueue(i);
            for (int i = 0; i < count; i++) arrayQueue.Dequeue();
            stopwatch.Stop();
            Console.WriteLine($"{count} operations: {stopwatch.ElapsedMilliseconds} ms");
        }

        // Тестування черги на основі зв'язного списку
        Console.WriteLine("LinkedListQueue performance:");
        foreach (int count in operationCounts)
        {
            var linkedListQueue = new LinkedListQueue<int>();
            var stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < count; i++) linkedListQueue.Enqueue(i);
            for (int i = 0; i < count; i++) linkedListQueue.Dequeue();
            stopwatch.Stop();
            Console.WriteLine($"{count} operations: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}