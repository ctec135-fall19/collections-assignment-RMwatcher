/*
Author: Richard Mora
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4 - Collections

Stack and Queue

region Stack: Declare and initialize a stack using initialization syntax with 
    the numbers 1 through 5.

    Showcase the use of the enumerator or foreach loop to print the members 
    in the stack.

    Print out a peek at the top member in the stack and write a loop that 
    pops the elements off the stack and print each one

region Queue: Declare a queue and initialize the queue with the numbers 1 
    through 5 by using a for loop.

    Showcase the use of the enumerator or foreach loop to print out the 
    members in the queue.

    print a peek at the top member in the queue.

    Afterwards, write a loop that dequeues the elements from the queue and 
    print out each one.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            Console.WriteLine("Stack\n");
            // I create a new stack object that takes in ints as values which 
            // I named it stackNum.
            Stack<int> stackNum = new Stack<int>();

            // I take a for loop to iterate 5 times which each time I use the
            // Push() method to add the number 1 to 5 to the stack object
            // stackNum.
            for (int num = 0; num < 5; num++)
            {
                stackNum.Push(num + 1);
            }
            
            // I use a foreach loop to iterate through stackNum one at a time
            // until it reaches the end of stackNum. I then print out each 
            // number in stackNum one line at a time.
            foreach (int num in stackNum)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine(stackNum.Peek());

            Console.WriteLine();
            // I created a int object called size which takes in the value of
            // the size of stackNum using the Count() method alongside 
            // stackNum
            int size = stackNum.Count();

            // this uses a for loop where as long as num which equals zero is
            // less than size (the size of stackNum), this loop will continue.
            // In the loop, it'll print out the elements inside stackNum that 
            // has been removed from stackNum using the Pop() method one at a 
            // time.
            for (int num = 0; num < size; num++)
            {
                Console.WriteLine(stackNum.Pop());
            }
            
            #endregion

            #region Queue
            Console.WriteLine("Queue\n");
            // Here I created a new Queue int object called QueueNum that 
            // take int as values.
            Queue<int> QueueNum = new Queue<int>();

            // in this for loop, I add in the number 1 through 5 into QueueNum
            // one at a time using the Enqueue() method. The loop will 
            // continue to iterate as long as num (which equals 0) is less 
            // 5.
            for (int num = 0; num < 5; num++)
            {
                QueueNum.Enqueue(num + 1);
            }
            
            // this foreach loop allows me to loop through the length of 
            // QueueNum while I print out each element inside QueueNum one 
            // line at a time
            foreach (int value in QueueNum)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // I print out the result of QueueNum.Peek() where it select the
            // top element of QueueNum using the Peek() method to do so.
            Console.WriteLine(QueueNum.Peek());
            Console.WriteLine();

            // I create an int object called size2 that takes the value of the
            // size of QueueNum by using the Count() method to do so.
            int size2 = QueueNum.Count();

            // this for loop lets me print out each QueueNum element that I
            // deleted off with Dequeue() method. This continues until the 
            // condition (as long as num is less than size2) is no longer
            // true.
            for (int num = 0; num < size2; num++)
            {
                Console.WriteLine(QueueNum.Dequeue());
            }
            #endregion
        }
    }
}
