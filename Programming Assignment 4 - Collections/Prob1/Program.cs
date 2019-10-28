/*
Author: Richard Mora
Date: 10/25/2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4 - Collections

Arrays and List<T>

region simple arrays: Create an int array with the size of 5 elements.

    Initialize the array using a for loop while giving the array numbers
    11 through 15 for each element.

    Use a foreach loop to print out the elements of the array

region List<T>: Create a list of int, then use a for loop to initialize the 
    list while giving the list numbers 21 through 25.

    Use a foreach loop to print out the elements of the list, afterwards update
    the values in the list to 31 through 35 using indexing.

    Print out the new values using a for loop and indexing.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple arrays
            // I created a new int array called MyInt with a size of 5 meaning
            // it can hold 5 elements
            int[] MyInt = new int[5];

            // in this for loop, I assign each element or index a number from 11 
            // through 15. This continues as long as num which equals zero is 
            // less than the size of MyInt.
            for (int num = 0; num < MyInt.Length; num++)
            {
                MyInt[num] = num + 11;
            }

            // I use a foreach loop to iterate through MyInt where I print out
            // each element inside MyInt one line at a time until it reaches
            // the end of MyInt.
            foreach (int item in MyInt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            #endregion

            #region List<T>
            // Here I create a new List object called MyList where it takes 
            // int as values
            List<int> MyList = new List<int>();

            // I use a for loop to add ints into MyList using the Add() method
            // to add the numbers 21 through 25 to MyList. This loop will 
            // continue until num is no longer less than 5.
            for (int num = 0; num < 5; num++)
            {
                MyList.Add(num + 21);
            }

            // I use a foreach loop to print out the elements inside of MyList
            // one line at a time
            foreach (int item in MyList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // I use a for loop to insert new values into MyList using the 
            // Insert() method where num acts as a index and I add in numbers
            // 31 through 35 into MyList until num is no longer less than 5.
            for (int num = 0; num < 5; num++)
            {
                MyList.Insert(num, (num + 31));
            }

            // I use a for loop where I iterate through MyList and use the 
            // Remove() method to delete the numbers 21 to 25 from MyList 
            // until num is no longer less than 5.
            for (int num = 0; num < 5; num++)
            {
                MyList.Remove(num + 21);
            }

            // I use a for loop to iterate through MyList where I print out 
            // each element inside MyList using index notation until num is 
            // no longer less than the size of MyList using Count() method
            // to get the size of MyList.
            for (int num = 0; num < MyList.Count; num++)
            {
                Console.WriteLine(MyList[num]);
            }
            #endregion
        }
    }
}
