using AlgorithmsDataStructures.Algo.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsDataStructures.Algo.Test
{
    public class BasicsTest
    {
        [Fact]
        public void SumOrTripleTest()
        {
            Basics basics = new Basics();

            Assert.Equal(3, basics.SumOrTriple(1, 2));
            Assert.Equal(12, basics.SumOrTriple(2, 2));
        }

        [Fact]
        public void DifferenceOrTripleTest()
        {
            Basics basics = new Basics();

            Assert.Equal(6, basics.DifferenceOrTriple(53));
            Assert.Equal(21, basics.DifferenceOrTriple(30));
        }

        [Fact]
        public void Given30Test()
        {
            Basics basics = new Basics();

            Assert.True(basics.Given30(30, 0));
            Assert.True(basics.Given30(25, 5));
            Assert.False(basics.Given30(20, 25));
        }
    }
}
