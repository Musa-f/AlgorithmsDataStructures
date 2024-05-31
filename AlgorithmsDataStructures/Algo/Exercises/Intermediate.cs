using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.Algo.Exercises
{
    //LEETCODE EXERCISES
    public class Intermediate
    {
        public static bool IsValid(string s)
        {
            Stack<char> stack = new();

            foreach (char c in s)
            {
                if (c == '{' || c == '[' || c == '(')
                {
                    stack.Push(c);
                }
                else if (c == '}' || c == ']' || c == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char last = stack.Pop();

                    if ((c == '}' && last != '{') ||
                        (c == ']' && last != '[') ||
                        (c == ')' && last != '('))
                    {
                        return false;
                    }
                } 
            }

            if (s.Length <= 1 || stack.Count != 0) return false;

            return true;
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> medianList = [0];

            int i = 0, j = 0;

            while (i < nums1.Length || j < nums2.Length)
            {
                if (i < nums1.Length && (j >= nums2.Length || nums1[i] <= nums2[j]))
                {
                    medianList.Add(nums1[i]);
                    i++;
                }
                else if (j < nums2.Length)
                {
                    medianList.Add(nums2[j]);
                    j++;
                }
            }

            int lastNumber = medianList.Count - 1;
            int index;
            double result;
            if (lastNumber % 2 == 0)
            {
                index = lastNumber / 2;
                int nextIndex = index + 1;
                result = (medianList[index] + medianList[nextIndex]) / 2.0;
            }
            else
            {
                index = (lastNumber + 1) / 2;
                result = medianList[index];
            }

            return result;
        }
        public static int LengthOfLongestSubstring(string s)
        {
            string[] stringAsArray = s.Select(c => c.ToString()).ToArray();
            List<string> values = [];
            List<string> temporaryString = [];
            int biggest = 0;

            for (int i = 0; i < stringAsArray.Length; i++)
            {
                if (temporaryString.Contains(stringAsArray[i]) || i + 1 == stringAsArray.Length)
                {
                    if (i + 1 == stringAsArray.Length && !temporaryString.Contains(stringAsArray[i]))
                        temporaryString.Add(stringAsArray[i]);

                    values.Add(string.Concat(temporaryString));

                    int indexToRemove = temporaryString.IndexOf(stringAsArray[i]);
                    if (indexToRemove >= 0)
                        temporaryString.RemoveRange(0, indexToRemove + 1);

                    if (values.Last().Length > biggest)
                        biggest = values.Last().Length;
                }

                temporaryString.Add(stringAsArray[i]);
            }

            return biggest;
        }

        public static int LengthOfLongestSubstringBis(string s)
        {
            Dictionary<char, int> charIndexMap = [];
            int longestSubstringLength = 0;
            int start = 0;

            for (int end = 0; end < s.Length; end++)
            {
                if (charIndexMap.TryGetValue(s[end], out int value))
                {
                    start = Math.Max(start, value + 1);
                }

                charIndexMap[s[end]] = end;
                longestSubstringLength = Math.Max(longestSubstringLength, end - start + 1);
            }

            return longestSubstringLength;
        }
        public static int RomanToInt(string s)
        {
            int result = 0;
            char[] letters = s.ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                switch(letters[i])
                {
                    case 'I':
                        if (i + 1 < letters.Length && (letters[i + 1] == 'V' || letters[i + 1] == 'X'))
                            result -= 1;
                        else
                            result += 1;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'X':
                        if (i + 1 < letters.Length && (letters[i + 1] == 'L' || letters[i + 1] == 'C'))
                            result -= 10;
                        else
                            result += 10;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'C':
                        if (i + 1 < letters.Length && (letters[i + 1] == 'D' || letters[i + 1] == 'M'))
                            result -= 100;
                        else
                            result += 100;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'M':
                        result += 1000;
                        break;

                }
            }
            
            return result;
        }
        public static LinkedList<int> AddTwoNumbers(LinkedList<int> l1, LinkedList<int> l2)
        {
            LinkedList<int> result = new();
            int carry = 0;

            LinkedListNode<int>? node1 = l1.First;
            LinkedListNode<int>? node2 = l2.First;

            while (node1 != null || node2 != null || carry != 0)
            {
                int sum = (node1 != null ? node1.Value : 0) + (node2 != null ? node2.Value : 0) + carry;
                carry = sum / 10;

                result.AddLast(sum % 10);

                if (node1 != null) node1 = node1.Next;
                if (node2 != null) node2 = node2.Next;

            }

            return result;
        }
        public bool IsPalindrome(int num)
        {
            string numToString = num.ToString();
            char[] z = [.. numToString]; //toArray()
            char[] ints = new char[z.Length];

            for (int i = z.Length - 1; i >= 0; i--)
            {
                ints[z.Length - (i + 1)] = z[i];
            }

            string concat = string.Join("", ints);

            return concat == numToString;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
    }
}
