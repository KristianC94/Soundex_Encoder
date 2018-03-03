// Author: Kristian Curcic
// SID: 14103017
// CMP5216 Advanced Software Development UG2 2015/16 Assignment 1
// Exercise 1 - Soundex Encoding
// Soundex encoder class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundexEncoding
{
    class Soundex
    {
        // Partial encoding
        public string EncodeSoundex(string text)
        {
            text = text.ToUpper(); 
            // Initialise string builder
            StringBuilder soundex = new StringBuilder();

            // Loop, looks for characters and adds them to string builder
            foreach (char chr in text)
            {
                if (char.IsLetter(chr)) 
                    AddChrs(soundex, chr);
            }

            // Converts StringBuilder to new string and returns it
            return soundex.ToString();
        }

        // Full encoding
        public string EncodeSoundexFull(string text)
        {
            text = text.ToUpper();
            StringBuilder soundex = new StringBuilder();

            foreach (char chr in text)
            {
                if (char.IsLetter(chr))
                    AddChrsFull(soundex, chr);
            }

            RemoveZeros(soundex);
            return soundex.ToString();
        }

        // For partial encoding
        private void AddChrs(StringBuilder soundex, char chr)
        {
            string encoding = GetGroups(chr);
            // Adds characters to soundex
            soundex.Append(encoding);
        }

        // For full encoding
        private void AddChrsFull(StringBuilder soundex, char chr)
        {
            string encoding = GetGroups(chr);

            if (soundex.Length == 0)
               soundex.Append(encoding);

            else
            {
                RemoveZeros(soundex);
                // Only adds character to soundex if it is different to previous character
                if (encoding != soundex[soundex.Length - 1].ToString())
                    soundex.Append(encoding);
            }
        }

        // Encodes letter groups in the string to numbers
        private string GetGroups(char chr)
        {
            string CharString = chr.ToString();

            if ("AEIOUHWY".Contains(CharString))
                return "0";
            else if ("BFPV".Contains(CharString))
                return "1";
            else if ("CGJKQSXZ".Contains(CharString))
                return "2";
            else if ("DT".Contains(CharString))
                return "3";
            else if (chr == 'L')
                return "4";
            else if ("MN".Contains(CharString))
                return "5";
            else if (chr == 'R')
                return "6";
            // In case anything other than a letter is typed in
            else return "";
        }

        // Removes zeros for full encoding
        private void RemoveZeros(StringBuilder soundex)
        {
            soundex.Replace("0", "");
        }

    }
}
