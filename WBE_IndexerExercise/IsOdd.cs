/*
 * Create a class called "IsOdd" that uses indexer to return true for odd numbers and false for even numbers. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_IndexerExercise
{
    class IsOdd
    {
        public bool this [int number]
        {
            get
            {
                return number % 2 == 1 ? true : false;
            }
        }
    }
}
