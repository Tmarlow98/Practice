using System;
using System.Text;
using System.Collections.Generic;

public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] words =
            { "the", "fox", "jumps", "over", "the", "dog" };
        LinkedList<string> sentence = new LinkedList<string>(words);
        Display(sentence, "The linked list values:");
        Console.WriteLine("sentence.Contains(\"jumps\") = {0}",
            sentence.Contains("jumps"));
        
        // Add the word 'today' to the beginning of the linked list. 
        sentence.AddFirst("today");
        Display(sentence, "Add 'today' to beginning of list");
        
        // Move the first node to be the last node.
        LinkedListNode<string> firstNode = sentence.First;
        sentence.RemoveFirst();
        sentence.AddLast(firstNode);
        Display(sentence, "Move first node to be the last node");
        
        // Change the last node to 'yesterday'
        sentence.RemoveLast();
        sentence.AddLast("yesterday");
        Display(sentence, "Change last node to yesterday");
        
        // Move the last node to the first node
        firstNode = sentence.Last;
        sentence.RemoveLast();
        sentence.AddFirst(firstNode);
        Display(sentence, "Move the last node to the first node");
        
        // Indicate the last occurence of 'the'
        LinkedListNode<string> lastOccurance = sentence.FindLast("the");
        IndicateNode(lastOccurance, "Indicate the last occurance of 'the'");
        
         // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
         sentence.AddAfter(lastOccurance, "lazy");
         sentence.AddAfter(lastOccurance, "old");
         IndicateNode(lastOccurance, "Add 'lazy' and 'old' after 'the'");

    }
    
    
    private static void Display(LinkedList<string> words, string test)
    {
        Console.WriteLine(test);
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    
    private static void IndicateNode(LinkedListNode<string> node, string test)
    {
        Console.WriteLine(test);
        if (node.List == null)
        {
            Console.WriteLine("Node '{0}' is not in the list.\n",
                node.Value);
            return;
        }

        StringBuilder result = new StringBuilder("(" + node.Value + ")");
        LinkedListNode<string> nodeP = node.Previous;

        while (nodeP != null)
        {
            result.Insert(0, nodeP.Value + " ");
            nodeP = nodeP.Previous;
        }

        node = node.Next;
        while (node != null)
        {
            result.Append(" " + node.Value);
            node = node.Next;
        }

        Console.WriteLine(result);
        Console.WriteLine();
    }
    
    }
