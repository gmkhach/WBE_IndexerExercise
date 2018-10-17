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
            IsOdd testOdd = new IsOdd();
            Console.WriteLine(testOdd[5]);
            Console.WriteLine(testOdd[22]);

            IsEven testEven = new IsEven();
            Console.WriteLine(testEven[5]);
            Console.WriteLine(testEven[22]);
        }
    }
}
