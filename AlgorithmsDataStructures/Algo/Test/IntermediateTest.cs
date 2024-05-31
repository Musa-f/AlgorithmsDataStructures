using AlgorithmsDataStructures.Algo.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsDataStructures.Algo.Test
{
    public class IntermediateTest
    {
        [Fact]
        public void IsValidTest()
        {
            Assert.True(Intermediate.IsValid("()"));
            Assert.False(Intermediate.IsValid("["));
        }

        [Fact]
        public void LengthOfLongestSubstringTest()
        {
            Assert.Equal(3, Intermediate.LengthOfLongestSubstring("pwwkew"));
            Assert.Equal(3, Intermediate.LengthOfLongestSubstring("dvdf"));
            Assert.Equal(1, Intermediate.LengthOfLongestSubstring("bbbbb"));
            Assert.Equal(3, Intermediate.LengthOfLongestSubstring("abcabcbb"));
            Assert.Equal(5, Intermediate.LengthOfLongestSubstring("ckilbkd"));
        }

        [Fact]
        public void LengthOfLongestSubstringBisTest()
        {
            Assert.Equal(3, Intermediate.LengthOfLongestSubstringBis("pwwkew"));
            Assert.Equal(3, Intermediate.LengthOfLongestSubstringBis("dvdf"));
            Assert.Equal(1, Intermediate.LengthOfLongestSubstringBis("bbbbb"));
            Assert.Equal(3, Intermediate.LengthOfLongestSubstringBis("abcabcbb"));
            Assert.Equal(5, Intermediate.LengthOfLongestSubstringBis("ckilbkd"));
        }

        [Fact]
        public void RomanToIntTest()
        {
            Assert.Equal(1994, Intermediate.RomanToInt("MCMXCIV"));
        }

        [Fact]
        public void AddTwoNumbersTest()
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddLast(2);
            l1.AddLast(4);
            l1.AddLast(3);

            LinkedList<int> l2 = new LinkedList<int>();
            l2.AddLast(5);
            l2.AddLast(6);
            l2.AddLast(4);

            LinkedList<int> result = new LinkedList<int>();
            result.AddLast(7);
            result.AddLast(0);
            result.AddLast(8);

            Intermediate.AddTwoNumbers(l1, l2);

            Assert.Equal(result, Intermediate.AddTwoNumbers(l1,l2));
        }
    }
}
