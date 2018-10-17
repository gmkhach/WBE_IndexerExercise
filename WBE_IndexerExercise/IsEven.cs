/*
 * Create a class called "IsEven" that uses the previously created "IsOdd" class to return true for even numbers and false for odd numbers. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_IndexerExercise
{
    class IsEven
    {
        private IsOdd testOdd = new IsOdd();

        public bool this[int number]
        {
            get
            {
                return !testOdd[number] ? true : false;
            }
        }
    }
}
