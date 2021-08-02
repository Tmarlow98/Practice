using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        // A queue can be enumerated without disturbing its contents.
        foreach( string number in numbers )
        {
            Console.WriteLine("First queue elements: " + number);
        }

        Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());
        Console.WriteLine("Peek at next item to dequeue: {0}, {1}, {2}",
            numbers.Peek(), "FIFO", numbers.Count);

        // Create a copy of the queue, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        
        Queue<string> copyOfNumbers = new Queue<string>(numbers.ToArray());
        
        Console.WriteLine("\nCopy of first queue");
        foreach(Object obj in copyOfNumbers){
        Console.WriteLine("Copy of first queue elements: " + obj);
        }
        

        // Create an array twice the size of the queue and copy the
        // elements of the queue, starting at the middle of the
        // array.
        Console.WriteLine("\nArray Twice the size of first queue, copied to array");
        string[] arrayQueue = new string[numbers.Count *2];
        numbers.CopyTo(arrayQueue, numbers.Count);
        foreach(Object obj in arrayQueue){
        Console.WriteLine("Array elements: " + obj);
        }
        
        // Create a second queue, using the constructor that accepts an
        // IEnumerable(Of T).
        Queue<string> numbers2 = new Queue<string>(arrayQueue);
        Console.WriteLine("\nNew Queue with accepted arguemnts of IEnumerable(Of T)");
        foreach(Object obj in numbers2){
        Console.WriteLine("2nd Queue elements: " + obj);
        }
        
    }
}
