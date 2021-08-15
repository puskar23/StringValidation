using System;
using System.IO;
using System.Linq;

namespace Stringvalid
{

    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // challenge1();
            challenge2();
            Console.ReadKey();



        }
        /// <summary>
        /// Consider a string to be valid if all characters of the string appear the same number of times. 
        /// It is also valid if he can remove just 1 character at 1 index in the string, 
        /// and the remaining characters will occur the same number of times.Given a string , 
        /// determine if it is valid.If so,return YES, otherwise return NO.
        /// </summary>

        static int CHARS = 26;
        static bool PrintValidString(string str)
        {
            int[] freq = new int[CHARS];
            int i = 0;
            //Freq stores the frequency of each character
            for (i = 0; i < str.Length; i++)
            {
                freq[str[i] - 'a']++;
            }

            int freq1 = 0, count_freq1 = 0;// Find first character with non-zero frequency
            for (i = 0; i < CHARS; i++)
            {
                if (freq[i] != 0)
                {
                    freq1 = freq[i];
                    count_freq1 = 1;
                    break;
                }
            }

            // Find a character with frequency different
            // from freq1.
            int j, freq2 = 0, count_freq2 = 0;
            for (j = i + 1; j < CHARS; j++)
            {
                if (freq[j] != 0)
                {
                    if (freq[j] == freq1)
                    {
                        count_freq1++;
                    }
                    else
                    {
                        count_freq2 = 1;
                        freq2 = freq[j];
                        break;
                    }
                }
            }
            for (int k = j + 1; k < CHARS; k++)
            {
                if (freq[k] != 0)
                {
                    if (freq[k] == freq1)
                    {
                        count_freq1++;
                    }
                    if (freq[k] == freq2)
                    {
                        count_freq2++;
                    }
                    else // If we find a third non-zero freq
                    {
                        return false;
                    }
                }
                // If counts of both frequencies is more than 1
                if (count_freq1 > 1 && count_freq2 > 1)
                {
                    return false;
                }
            }

            // Return true if we reach here
            return true;
        }
        public static void challenge1()
        {
            String str = "aabbccd";

            if (PrintValidString(str))
            {
                Console.WriteLine("YES");

            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        ///<summary>
        ///given an array of integers, find the subset of non-adjacent elements with the maximum sum. 
        ///Calculate the sum of that subset. 
        /// It is possible that the maximum sum is 0, the case when all elements are negative.

        ///</summary>
        ///


        public static void printSubArray(int[] input, int currIndex)
        {

            if (currIndex == input.Length)
                return;

            //print all the subarray from currIndex to end
            string result = " ";
            int sum = 0;
            for (int i = currIndex; i < input.Length; i++)
            {
                sum = sum + input[i];
                result += " " + input[i] + " ";
                Console.WriteLine("[" + result + "]" + "=" + sum);
            }
            printSubArray(input, currIndex + 1);
        }
       

            public static void challenge2()

        {
                int[] input = { -1, 2, 3 };
                printSubArray(input, 0);



         }








    }
    
}
