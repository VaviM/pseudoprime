using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR
{
    class Program
    {
        static void Main(string[] args)
        {
            // PseudoPrime.Sequence First = new PseudoPrime.Sequence(new List<uint> { 2,3,5,7,11},5);//the same as next
            for (uint i = 0; i < 13; i++)
            {
                PseudoPrime.Sequence First = new PseudoPrime.Sequence(5, i);
                PseudoPrime.Sequence Second = new PseudoPrime.Sequence(new List<uint> { 2, 3, 5, 7, 13 }, i);
                PseudoPrime.CreateOperators(ref First);
                PseudoPrime.CreateOperators(ref Second);
                PseudoPrime.CreateSequences(ref First, ref Second);
                PseudoPrime.CompareSequences(First, Second);
                Console.WriteLine(new string('*', 25));
            }
        }
    }
}
