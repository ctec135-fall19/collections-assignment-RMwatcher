/*
Author: Richard Mora
Date: 10/26/2019
CTEC 135: Microsoft Software Development with C#

Module 5, Programming Assignment 4 - Collections

Linked List

Demonstrate the use of the constructor taking an IEnumerable object.
    
Create a string array that has the first 5 to 10 words of your favorite 
    nursery rhyme.

Use those words as arguments when constructing the LinkedList object.

Print out the rhyme on a single line.

Create a node variable and walk the list to print out the values on a single 
    line matching the print line as above.

Remove a word from the middle of the list and print out the list on a single 
    line again to shows it's missing.

Add the word you removed eariler back into the list and print out the line 
    again to show it's back on the list.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4
{
    class Program
    {
        static void Main(string[] args)
        {
            // here I created a new string array called song and filled it 
            // with strings "It's" "just" "you" "and "me" inside of song as 
            // elements
            string[] song = { "It\'s ", "just ", "you ", "and ", "me " };

            // I use a foreach loop to iterate through the song array to 
            // print out each element on a single line until it reaches the 
            // end of the song array.
            foreach (string part in song) 
            {
                Console.Write(part);
            }
            Console.WriteLine();
            Console.WriteLine();

            // here I created a new LinkedList object called Lyrics that 
            // takes strings as values
            LinkedList<string> Lyrics = new LinkedList<string>();

            // I use a for loop to use the AddLast() method to add each 
            // element from the song array into the LinkedList object 
            // Lyrics using verse as a index. This loop will continue as long
            // as verse is less than the size of the song array by using the 
            // Length keyword.
            for (int verse = 0; verse < song.Length; verse++)
            {
                Lyrics.AddLast(song[verse]);
            }

            // Here I created a new LinkedListNode<string> called Pieces 
            // where it takes the value of the first node of Lyrics using 
            // the First keyword.
            LinkedListNode<string> Pieces = Lyrics.First;

            Console.WriteLine("Lyrics from LinkedList edition\n");

            // Here I use the while loop to print out each node of Lyrics
            // starting from the first node and going to the next node using 
            // the Next keyword and printing out that node in the process. 
            // This continues as long as the value of Pieces doesn't equal 
            // to null where the LinkedList doesn't have a value you added
            // yourself or the end of the list
            while (Pieces != null)
            {
                // the Keyword Value is used to print out the value of each
                // node inside Lyrics or the object Pieces which it represents
                Console.Write("{0}", Pieces.Value);
                Pieces = Pieces.Next;
            }
            Console.WriteLine();

            // Here I created a new LinkedListNode<string> called size where
            // it has the value of the node inside of Lyrics that has the 
            // value of the string "you " using the Find() method
            LinkedListNode<string> size = Lyrics.Find("you ");

            // Here I remove a node from Lyrics using the Remove() method
            // the node that has a string value of "you " inside of Lyrics
            // or the object size which has that value.
            Lyrics.Remove(size);

            // again I created a new LinkedListNode<string> called words
            // that has the value of the first node from Lyrics.
            LinkedListNode<string> words = Lyrics.First;

            // Similar to the while loop from eariler, this prints out each
            // node from Lyrics starting at the first node or the object 
            // words. The differences here is this prints out the list without
            // the node containing the string "you ".
            while (words != null)
            {
                // the Keyword Value is used to print out the value of each
                // node inside Lyrics or the object words which it represents
                // similar to the while loop from above
                Console.Write("{0}", words.Value);
                // the Next keyword select the next node from words or Lyrics
                // and starts the loop again.
                words = words.Next;
            }
            Console.WriteLine();

            // Here I created a new LinkedListNode<string> called look where
            // I use the Find() method again to look for a node that has 
            // the string value of "just " in it.
            LinkedListNode<string> look = Lyrics.Find("just ");

            // here I added a brand new node to Lyrics where I use the 
            // AddAfter() method to add the new node with the string value 
            // "you " right after the node that has the string value "just "
            // or the lood object which has the value of "just ".
            Lyrics.AddAfter(look, "you ");

            //  Here I created a new LinkedListNode<string> called final 
            // where it takes on the value of the first node from Lyrics
            LinkedListNode<string> final = Lyrics.First;

            // Similar to the while loop from eariler, this prints out each
            // node from Lyrics starting at the first node or the object 
            // final. The differences here is I added a node back into Lyrics
            // that has the string value of "you " after the node that has 
            // the string value of "just ". This should return the list back 
            // to it was before.
            while (final != null)
            {
                // the Keyword Value is used to print out the value of each
                // node inside Lyrics or the object final which it represents
                // similar to the while loop from above
                Console.Write("{0}", final.Value);
                // the Next keyword select the next node from final or Lyrics
                // and starts the loop again.
                final = final.Next;
            }
            Console.WriteLine();
        }
    }
}
