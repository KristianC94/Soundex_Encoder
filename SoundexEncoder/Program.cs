// Author: Kristian Curcic
// SID: 14103017
// CMP5216 Advanced Software Development UG2 2015/16 Assignment 1
// Exercise 1 - Soundex Encoding
// Main program

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundexEncoding
{
    class SoundexEncodeTest
    {

        // Main
        static void Main(string[] args)
        {
            SoundexEncodeTest Program = new SoundexEncodeTest();
            Program.Run();
            Pause("\n\nPress any key to quit.");
        }

       // To exit program
        static void Pause(string s)
        {
            Console.Write(s);
            Console.Read();
        }

        // All functionality here
        public void Run()
        {
            // Variables
            string word1, word2;
            Soundex encode;

            // Short explanation of the program
            Console.WriteLine("Exercise 1 - Soundex Encoder");
            Console.WriteLine("Developed by Kristian Curcic");
            Console.WriteLine("\nThis program encodes words entered by the user to Soundex.");
            Console.WriteLine("Words can be encoded both partially and fully.");
            Console.WriteLine("Similar sounding words should be encoded to the same numbers in full Soundex.");

            // Getting user inputs
            Console.Write("\n\nEnter a word: ");
            word1 = Console.ReadLine();
            Console.Write("\nEnter a similar sounding word: ");
            word2 = Console.ReadLine();

            // Initialise Soundex class
            encode = new Soundex();

            // Method abbreviations
            string par1 = encode.EncodeSoundex(word1);
            string par2 = encode.EncodeSoundex(word2);
            string ful1 = encode.EncodeSoundexFull(word1);
            string ful2 = encode.EncodeSoundexFull(word2);

            // Returns partial Soundex encoding 
            Console.WriteLine("\n{0} is encoded to {1} in Soundex.", word1, par1);
            Console.WriteLine("{0} is encoded to {1}.", word2, par2);

            // Returns full Soundex encoding
            Console.WriteLine("\nFully encoded the words are {0} and {1}.", ful1, ful2);

            // Returns whether or not words sound similar
            if (ful1 == ful2)
                Console.WriteLine("The words sound similar.");
            else Console.WriteLine("The words do not sound similar.");
        }
    }
}
