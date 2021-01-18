using System;

namespace BTTrienKhaiQueueLKVong
{
    class Program
    {
        static void Main(string[] args)
        {
             LinkedList q = new LinkedList(); 
    q.front = q.rear = null; 
  
    // Inserting elements in Circular Queue  
    enQueue(q, 14); 
    enQueue(q, 22); 
    enQueue(q, 6); 
  
    // Display elements present in 
    // Circular Queue  
    displayQueue(q); 
  
    // Deleting elements from Circular Queue  
    Console.Write("Deleted value = {0:D}", deQueue(q));                          
    Console.Write("Deleted value = {0:D}",   deQueue(q));                            
    // Remaining elements in Circular Queue  
    displayQueue(q); 
  
    enQueue(q, 9); 
    enQueue(q, 20); 
    displayQueue(q); 
        }

        public static void enQueue(LinkedList q,int value)                         
{ 
    Node temp = new Node(); 
    temp.data = value; 
    if (q.front == null) 
    { 
        q.front = temp; 
    } 
    else
    { 
        q.rear.link = temp; 
    } 
  
    q.rear = temp; 
    q.rear.link = q.front; 
} 
  
// Function to delete element from 
// Circular Queue  
public static int deQueue(LinkedList q) 
{ 
    if (q.front == null) 
    { 
        Console.Write("Queue is empty"); 
        return int.MinValue; 
    } 
  
    // If this is the last node to be deleted  
    int value; // Value to be dequeued 
    if (q.front == q.rear) 
    { 
        value = q.front.data; 
        q.front = null; 
        q.rear = null; 
    } 
    else // There are more than one nodes 
    { 
        Node temp = q.front; 
        value = temp.data; 
        q.front = q.front.link; 
        q.rear.link = q.front; 
    } 
  
    return value; 
} 
  
// Function displaying the elements  
// of Circular Queue  
public static void displayQueue(LinkedList q) 
{ 
    Node temp = q.front; 
    Console.Write("Elements in Circular Queue are: "); 
    while (temp.link != q.front) 
    { 
        Console.Write("{0:D} ", temp.data); 
        temp = temp.link; 
    } 
    Console.Write("{0:D}", temp.data); 
} 
    }
}
