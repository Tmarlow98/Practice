using System;
using System.Collections;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
    	int count = 1;
        Stack numbers = new Stack();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        // A stack can be enumerated without disturbing its contents.
        foreach( string number in numbers )
        {
            Console.WriteLine("Stack index at " + count + " is: " + number);
            count++;
        }
        
        count = 1;
        
        Console.WriteLine();
        Console.WriteLine("Last number entered is: " + numbers.Peek());
        Console.WriteLine("After running: numbers.Pop(), " + numbers.Peek() 
        + " is removed because \nit was the last collection entered. LIFO");
        numbers.Pop();
        
        Console.WriteLine();
        foreach(string number in numbers){
        	Console.WriteLine("Stack index at " + count + " is: " + number);
            count++;
        }
        count = 1;
        
        Console.WriteLine();
        object[] stackArray = numbers.ToArray();
        
        foreach(Object obj in stackArray){
        Console.WriteLine("Object Array representation: " + obj);
        }
        
        Console.WriteLine();
        
        Stack<string> GenericNames = new Stack<string>();
        GenericNames.Push("Tiger");
        GenericNames.Push("Cat");
        GenericNames.Push("Loki");
        GenericNames.Push("Tyler");
        GenericNames.Push("Dylan");
        
        foreach(Object obj in GenericNames){
        Console.WriteLine("Generic Stack at index: " + count + " is: " + obj);
        count++;
        }
        count = 1;
        Console.WriteLine();
        
        Console.WriteLine("Copy of Generic Stack using ToArray() method");
        Stack<string> GenericNames2 = new Stack<string>(GenericNames.ToArray());
        
        foreach(Object obj in GenericNames2){
        Console.WriteLine("Copy of Generic Stack using ToArray() at index: " 
        + count + " is: " + obj);
        count++;
        }
        count = 1;
        Console.WriteLine();
        Console.WriteLine("Create an array twice the size of the stack and copy the          		 \nelements of the stack, starting at the middle of the array");
        
        // Create an array twice the size of the stack and copy the
        // elements of the stack, starting at the middle of the
        // array
        
        string[] twiceSize = new string[numbers.Count * 2];
        numbers.CopyTo(twiceSize, numbers.Count);
        
        Stack<string> anotherStack = new Stack<string>(twiceSize);
        
        foreach(Object obj in anotherStack){
        Console.WriteLine("Copy of Generic Stack using ToArray() at index: " 
        + count + " is: " + obj);
        count++;
        }
        count = 1;
        
    }
}
