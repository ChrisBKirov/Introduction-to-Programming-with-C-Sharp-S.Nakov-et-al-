﻿/*
   <summary>     
   TITLE              K combinations out of n   Chapter7Exercise25.cs
   S.Nakov, V.Kolev et al.    "Introduction to Programming with C#" 
   COMMENT
           Objective: Read n and k. Print the all possible combinations
                      (without repetition) of k elements within [1, n].  

                      n! / k!(n - k)!
               Input: -
              Output: -
   </summary>
   <author>Chris B. Kirov</author>
   <datecreated>18.03.2016</datecreated>
*/
using System;

namespace ProgrammingBasicsCSharp
{
    class Chapter7Exercise25
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            PrintCombinations(n, k);

            Console.WriteLine();
        }
        //-----------------------------------------------------------------------

        /*
            Method: PrintCombinations(n, k);

            Wrapper for the recursive function.
            It prints all the k combinations
            out of n elements.
        */
        static void PrintCombinations(int n, int k)
        {
            int[] elements = new int[n];
            InitializeArray(elements, n);

            Console.Write("->");
            Combinations(elements, k, 0, new int[k]);
        }
        //-----------------------------------------------------------------------

        /*
            Method:  Combinations(arr, length, startPosition, ithCombination);

            Recursive function that accumulates all the (k == length) combinations 
            in array ithCombination and when filled up it prints it.

            Base case: check arguments and if
                       k == currentNumberOfElementsInCombination:  => print them

            Recursive step: - run through the remaining elements.
                            - add the element at position [currentRecursionDepth]
                              to the array of combinations 
                              at [k - currentNumberOfElementsInCombination]. 
                            - exclude added element, update currentNumberOfElementsInCombination.
                            - calls itself with updated arguments.
        */
        static void Combinations(int[] arr, int length, int startPosition, int[] ithCombination)
        {
            // if k elements added to the combination: print it
            if (length == 0)
            {
                PrintArray(", ", ithCombination);
                return;
            }

            // go through remaining elements 
            for (int i = startPosition; i <= arr.Length - length; i++)
            {
                ithCombination[ithCombination.Length - length] = arr[i];

                Combinations(arr, length - 1, i + 1, ithCombination);
            }
        }
        //-----------------------------------------------------------------------

        /*
            Method: PrintArray(label, arr);

            Print label and the array elements;  
        */
        static void PrintArray(string label, int[] arr)
        {
            Console.Write("{");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("}");
            Console.Write(label);
        }
        //-----------------------------------------------------------------------

        /*
            Method: InitializeArray();

        */
        static void InitializeArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
        }
    }
}
