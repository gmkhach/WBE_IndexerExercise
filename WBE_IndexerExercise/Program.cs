﻿/*
 * Create a class called "IsOdd" that uses indexer to return true for odd numbers and false for even numbers. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_IndexerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            IsOdd test = new IsOdd();
            Console.WriteLine(test[5]);
            Console.WriteLine(test[22]);
        }
    }
}
