/*
Author: Richard Mora
Date: 10/26/2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4 - Collections

Dictionary

Declare a dictionary and initalize it to create three entries which are 
    (1, "one"), (2, "two"), and (3, "three"). Use both Add() method and [] 
    when initalization.

    Add another entry to the dictionary: (9, "ninety-nine") and use a 
    enumerator or a foreach loop to print both keys and values of each 
    entries.

    Reassign the value of 99 from "ninety-nine" to "99" and print out the 
    new value using indexing notation.

    Remove the 2 item and use a foreach loop to print out the whole 
    dictionary to show the item is gone.

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here I created a DIctionary object that takes in a int for the 
            // key and a string for the value of my new Dictionary called
            // MyDictionary.
            Dictionary<int, string> MyDictionary = new Dictionary<int, string>();

            // Here I use the Add() method to add a key 1 and the value "one"
            // to MyDictionary
            MyDictionary.Add(1,"one");
            // for the next three lines of code, I use indexing notation to
            // add a key inside of [] and a value after the equal sign. 2, 3
            // and 99 are the keys and "two", "three", and "ninety-nine"
            // as values
            MyDictionary[2] = ("two");
            MyDictionary[3] = ("three");
            MyDictionary[99] = ("ninety-nine");

            Console.WriteLine("MyDictionary's Keys");

            // this foreach loop iterates through MyDictionary's keys using 
            // the keyword Keys to do so. This loop prints out the keys one
            // line at a time
            foreach (int num in MyDictionary.Keys)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("MyDictionary's Values");
            // this foreach loop iterates through MyDictionary's values using
            // the keyword Values to do so. This loop prints out the values 
            // one line at a time
            foreach (string text in MyDictionary.Values)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();

            // Here is where I remove the key 99 along with it's value
            MyDictionary.Remove(99);

            // Here I added a new key and value in MyDictionary where the 
            // is 99 and it's value is "99".
            MyDictionary[99] = "99";

            Console.WriteLine("MyDictionary's Keys after changes");

            // this foreach loop is where I prints out the MyDictionary's 
            // key using the Keys keyword. This foreach loop prints out each
            // keys in MyDictionary after adding the new key and value.
            foreach (int num in MyDictionary.Keys)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("MyDictionary's Values after changes");
            // this foreach loop it where I print out the MyDictionary's 
            // values using the keyword Values. This foreach loop prints out
            // each values in MyDIctionary after adding the new key and value
            foreach (string text in MyDictionary.Values)
            {
                Console.WriteLine(text);
            }

            // here I removed a key from MyDictionary using the Remove() 
            // method removing the 2 key along with it's value
            MyDictionary.Remove(2);
            Console.WriteLine();

            Console.WriteLine("After removing item 2");
            // the following two foreach loops each prints out both the keys
            // and values of MyDictionary. Each loop uses the Keys and the
            // Values keywords to print out both the keys and values of 
            // MyDictionary. The first foreach loop prints out the keys
            // while the second prints out the values.
            foreach (int num in MyDictionary.Keys)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            foreach (string text in MyDictionary.Values)
            {
                Console.WriteLine(text);
            }
            Console.WriteLine();

        }
    }
}
