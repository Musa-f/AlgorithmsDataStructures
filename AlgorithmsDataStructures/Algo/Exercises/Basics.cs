using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Algo.Exercises
{
    // https://www.w3resource.com/csharp-exercises/basic-algo/index.php
    public class Basics
    {
        public int SumOrTriple(int a, int b)
        {
            return a == b
                ? (a + b) * 3
                : a + b;
        }

        public int DifferenceOrTriple(int x)
        {
            int y = 51;
            return x > y
                ? (x - y) * 3
                : y - x;
        }

        public bool Given30(int a, int b)
        {
            int c = 30;
            if (a == c || b == c)
                return true;
            else if (a + b == c)
                return true;
            else return false;
        }

    }
}
