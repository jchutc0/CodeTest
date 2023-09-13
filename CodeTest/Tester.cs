using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public static class Tester
    {
        /// <summary>
        /// Function that take a string and returns true if the string is a palindrome
        /// </summary>
        /// <param name="input">string</param>
        /// <returns>bool</returns>
        public static bool IsPalindrome(string input)
        {
            // create indexes to the first and last elements of the string
            int startIndex = 0;
            int endIndex = input.Length - 1;
            // check that the characters at the start and end of the string are the same
            // if they are not, return false
            while(endIndex > startIndex) {
                if(input[startIndex] != input[endIndex]) {
                    // if the elements don't match, the string is not a palindrome
                    return false;
                } // if !=
                startIndex += 1;
                endIndex -= 1;
            } // iterate over string
            // if we get here, the two indexes met in the middle with no missed matches
            return true;
        }

        /// <summary>
        /// Function that takes a string and returns the count of each character in the string
        /// </summary>
        /// <param name="inpput">input string</param>
        /// <returns>Dictionary with each character from the string as the key and the count of each charter as the value</returns>
        public static Dictionary<char, int> CharacterCount(string inpput)
        {
            // set up output dictionary to return
            Dictionary<char, int> output = new Dictionary<char, int>();
            // iterate through string
            foreach(char c in inpput) {
                if(output.ContainsKey(c)) {
                    // if the dictionary contains a count for the character, increment it
                    output[c] += 1;
                } else {
                    // if the dictionary has no count for the character, make it 1
                    output[c] = 1;
                }
            } // iterate over string
            return output;
        }

        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetMatches(int[] input1, int[] input2)
        {
            List<int> outputList = new();   
            // iterate over input1
            foreach(int i in input1) {
                // check to see if input2 contains the value
                if(input2.Contains(i)) {
                    outputList.Add(i);
                } // if input2 contains the value
            } // iterate over input1
            // change outputList to array type for return
            // added distinct method to remove duplicates        
            return outputList.Distinct().ToArray();
        }


        /// <summary>
        /// Function that accepts two arrays of integers and returns an array of integers that are not in both arrays.
        /// </summary>
        /// <param name="input1">an array of integers</param>
        /// <param name="input2">an array of integers</param>
        /// <returns>an array of integers</returns>
        public static int[] GetDiff(int[] input1, int[] input2)
        {
            int[] matches = GetMatches(input1, input2);
            List<int> outputList = new();
            // add any elements of inputs into the output list that are not in matches
            // iterate over input1
            foreach(int i in input1) {
                if(!matches.Contains(i)) {
                    outputList.Add(i);
                }
            } // iterate over input1
            // iterate over input2
            foreach(int i in input2) {
                if(!matches.Contains(i)) {
                    outputList.Add(i);
                }
            } // iterate over input2
            // change outputList to array type for return
            // added distinct method to remove duplicates        
            return outputList.Distinct().ToArray();
        }
    }
}
