using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //DataStructures GitHub.
    //.https://github.com/anirban-s/data-structures-and-algorithms/tree/master/4.%20DS%20-%20Stack%20and%20Queue


    public class Solution
    {
        public static int NumOfClosedIsland(char[][] grid)
        {
            int totalClosedIsland = 0;

            for ( int i =0;i < grid.Length - 1; i++)
            {
                for ( int j = 0; j < grid[0].Length - 1;j++)
                {
                    ///If the row,col value is 1 or 2 then skip either water or Visited
                    if (grid[i][j] == '1' || grid[i][j] == '2') continue;
                    /// if the row col is zero the apply DFS
                    if (grid[i][j] == '0')
                    {
                        var status = MarkVisitedIslandByAllDirection(grid, i, j);
                       // Console.WriteLine($"{i} {j} {status}");
                        totalClosedIsland = status ? totalClosedIsland+1 : 0 ;
   
                    }
                }
            }


            return totalClosedIsland;
        }
        public static bool MarkVisitedIslandByAllDirection(char [] [] grid,int row ,int col)
        { 
            // Edge cases not to apply DFS
            if (row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length ) return false;
            if (grid[row][col] == '1' || grid[row][col] == '2') return true ;
             grid[row][col] = '2'; // Marking as visited
            var result = true;
            // If all side are true then only true 
            // result = result && recursionFn
            //For each and every element traverse all the direction is required.
            int[] x = { -1, -1, -1, 1, 1, 1, 0, 0 };
            int[] y = { -1, 0, 1, -1, 0, 1, 1, -1 };
            for ( int i = 0; i < 8; i++)
            {
               int dx = x[i] + row; ;
               int dy = y[i] + col;
                result &= MarkVisitedIslandByAllDirection(grid, dx  , dy  );
            }
            /*
            result &= MarkVisitedIslandByAllDirection(grid, row - 1, col -1);   
            result &= MarkVisitedIslandByAllDirection(grid, row - 1, col);
            result &= MarkVisitedIslandByAllDirection(grid, row - 1, col + 1);
            result &= MarkVisitedIslandByAllDirection(grid, row + 1, col -1);
            result &= MarkVisitedIslandByAllDirection(grid, row + 1, col);
            result &= MarkVisitedIslandByAllDirection(grid, row + 1, col + 1);
            result &= MarkVisitedIslandByAllDirection(grid, row, col + 1);
           result &= MarkVisitedIslandByAllDirection(grid, row, col - 1);
            */
            return result;
        }
        public static  int NumIslands(char[][] grid)
        {
            var result = 0;

            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != '1') continue; // Skip water and visited cells ('2')
                    result++;
                    MarkVisitedIsland(grid, i, j);
                }
            }

            return result;
        }
        private static void MarkVisitedIsland(char[][] grid, int row, int col)
        {
            if (row < 0 || row >= grid.Length) return;
            if (col < 0 || col >= grid[0].Length) return;

            if (grid[row][col] == '0') return;
            if (grid[row][col] == '2') return;

            grid[row][col] = '2'; // Mark as visited

            MarkVisitedIsland(grid, row - 1, col); // up
            MarkVisitedIsland(grid, row + 1, col); // down
            MarkVisitedIsland(grid, row, col - 1); // left
            MarkVisitedIsland(grid, row, col + 1); // right


        }
    }


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Adding TWO Linked List 
            var names = new LinkedList<string[]>();
            names.AddFirst(new string[] { "sridhar", "Raghunathan" });
            ListNode dummyHead = new ListNode(0); // head of newly generated list
            ListNode curr = dummyHead;
            int sum = 0;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0) //carry!=0 for the last node
            {
                sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                carry = sum / 10;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }

            return dummyHead.next;
        }
        public static void SwapNumber()
        {
            int[] array = new int[] { 45, 76, 77, 84, 89 };
            int i = 0; int j = array.Length - 1;
            while (i < j)
            {
                (array[j], array[i]) = (array[i], array[j]);
                i++;
                j--;
            }
        }
        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            var newNode = new ListNode();
            var ansNode = newNode;
            var data = new List<int>();
            foreach (var node in lists)
            {
                var tempNode = node;
                while (tempNode != null)
                {
                    data.Add(tempNode.val);
                    tempNode = tempNode.next;
                }
            }
            if (data.Count == 0) return null;
            data.Sort();
            for (int i = 0; i < data.Count; i++)
            {
                newNode.val = data[i];
                if (i != data.Count - 1)
                    newNode.next = new ListNode();
                newNode = newNode.next;
            }
            return ansNode;
        }

    }
    internal class LeetCodeClass
    {
        public static bool IsPalindromeRecursion (String name)
        {
            //Base case 
            if ( name.Length == 0  || name.Length == 1) return true;
            //Iteration - 1    racecar 
            //Iteration - 2    aceca 
            //Iteration - 3    cec
            //Iteration - 4   e  becomes base case 
            
            if ( name.ElementAt(0) == name.ElementAt(name.Length - 1))
            {
                return IsPalindromeRecursion(name.Substring(1, name.Length - 2 ));
            }



            // Additional case to handle the non palindromes
            return false;
        }
        public static string ReverseStringRecursion(string name)
        {
            if (name.Equals("")) return "";
            // fn(ello) + h
            // fn(llo) + e
            // fn(lo) + 1 here oll is returned 
            // fn(o) + l here ol is returned 
            //fn('') + o here o is returned 

            return ReverseStringRecursion(name.Substring(1)) + name.ElementAt(0);  

        }
        public static  int[] FindErrorNums(int[] nums)
        {
            //Brute force
            //use HashSet to find duplicate number
            //traverse the array to find the missing number
            var set = new HashSet<int>();
            int duplicate = -1, missing = -1;
            var list = new List<int>(nums);
            for (int i = 0; i < list.Count; i++)
            {
                if (set.Add(list[i]) == false)
                {
                    duplicate = nums[i];
                    break;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list.Contains(i + 1) == false)
                {
                    missing = i + 1;
                    break;
                }
            }
            return new int[] { duplicate, missing };
        }
        public static int[] SetMismatchLinq(int[] nums)
        {
            /*
             * You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, 
             * which results in repetition of one number and loss of another number.
                 Input: nums = [1, 2, 2, 4]
                 Output: [2,3] 3 is missing and it was duplicated
                 */
            var duplicate = nums.GroupBy(x => x).Where(g => g.Count() == 2).Select(g => g.Key).FirstOrDefault();
            var missingNumber = Enumerable.Range(1, nums.Length).Except(nums).FirstOrDefault(); 
            return new int[] { duplicate, missingNumber };
        }
        public static int[] SetMisMatch(int[] nums)
        {
            int duplicate = Int32.MinValue;
            int missingNumber = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!map.ContainsKey(i))
                    map.Add(i, 1);
                else
                    map[i] ++;
            }

            for(int i = 0; i <= nums.Length; i++)
            {
                if (map.ContainsKey(i))
                {
                    if (map[i] == 2)
                    {
                        duplicate = map[i];
                    }
                }
                else
                {
                    missingNumber = map[i];
                }
            }

            return new[] {duplicate, missingNumber}; 

        }
        public static void FindSingularNumber(int[] numbers)
        {
        //  Input: nums = [4, 1, 2, 1, 2]

      //  Output: 4
            int i = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int end = numbers.Length - 1;
            while (i < end)
            {
                var num = numbers[i];
                if (dict.ContainsKey(num)) { dict[num] += 1; }
                else dict.Add(num, 1);
                i++;
            }

            foreach (KeyValuePair<int, int> data1 in dict)
            {
                Console.WriteLine($"{data1.Key} {data1.Value}");
            }
        }
        public string LongestPalindromeSubstring(string s)
        {
        //amma //madam 
     //   Input: s = "babad"
//Output: "bab"

            int start = 0;
            int end = 0;
            int maxLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int length1 = FindLongestPalindrome(s, i, i);
                int length2 = FindLongestPalindrome(s, i, i + 1);
                int length = Math.Max(length1, length2);
                // 4 // babad 1 - (4 - 1) /2 => 1
                if (length > (end - start))
                {
                    start = i - (length - 1) / 2;
                    end = i + length / 2;
                    maxLength = length;
                }

            }
            return s.Substring(start, maxLength);
        }
        public int FindLongestPalindrome(string s, int left, int right)
        {

            if (left < 0 || right > s.Length)
                return 0;

            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return right - left - 1;
        }
        public static bool Palindrome(string newstring)
        {
            int start = 0;
            int end = newstring.Length - 1;
            while (start <= end)
            {
                if (newstring[start] != newstring[end]) return false;
                start++;
                end--;
            }
            return true;
        }
        public static IEnumerable<int> FindFibonacciSeries(short number)
        {
            // 1,1,2,3,5,8,13
            int previous = 0;
            int current = 1;
            int sum;

            for (int i = 0; i < number; i++)
            {
                //Iteration - 1 => 0 + 1 = 1
                //Iteration - 2 => 1 + 1 = 2
                //Iteration - 3 => 1 + 2 = 2
                sum = previous + current;
                previous = current;
                current = sum;
                yield return sum;
            }

        }
        public static int[] TwoSum()
        {
            // Finding the pair of 2 number based on target if 9 then pair 2,7
            int[] numbers = new int[] { 2, 17, 9, 7 };
            short target = 9;
            HashSet<int> dict = new HashSet<int>();
            //9 - 2 = 7
            //9 - 17 = 2
            for (int i = 0; i < numbers.Length; i++)
            {
                int diff = target - numbers[i];
                if (!dict.Contains(diff))
                {
                    dict.Add(numbers[i]); //2
                }
                else
                {
                    return new int[] { diff, numbers[i] };
                }
            }
            return new int[] { };
        }
        public static void Selectionsort(int[] arr)
        {
            int n = arr.Length;

            // One by one move boundary of unsorted subarray
            for (int i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first
                // element
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }
        public static int Fibonacci(int n)
        {
            // when we use recursive series always have base condition and return keyword must
            if (n == 1)
                return 1;

            int temp = n * Fibonacci(n - 1);
            return temp;

        }
        public static IEnumerable<KeyValuePair<int, int>> FindSingleNumber()
        {
            int[] numbers = new int[] { 2, 2, 1, 3, 45, 7 };
            int i = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int end = numbers.Length - 1;
            while (i < end)
            {
                var num = numbers[i];
                if (dict.ContainsKey(num)) { dict[num] += 1; }
                else dict.Add(num, 1);
                i++;
            }
            foreach (KeyValuePair<int, int> data1 in dict.Where(keyvalue => keyvalue.Value == 1))
            {
                Console.WriteLine($"{data1.Key} {data1.Value}");
            }
            return dict.Where(keyvalue => keyvalue.Value == 1);
        }
        public static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        public static void bubbleSort(int[] arr)
        {// Finds Biggest number moves to Last

            //(6 3 0 5 ) –> (3 6 0 5 ), Here, algorithm compares the first two elements, and swaps since 6 > 3.
            //(3 6 0 5) –> (3 0 6 5 ), Swap since 6 > 0
            //(3 0 6 5) –> (3 0 5 6 ), Swap since 6 > 5
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
        }
        public static (int Id, string Name, char Gender) PersonDataTuple()
        {
            (int Id, string Name, char Gender) person = (1, "Sridhar", 'M');
            return person;
        }
        public  static  void printLeaders( )
        {
/*
        Input: arr[] = { 16, 17, 4, 3, 5, 2 },
Output: 17, 5, 2

Input: arr[] = { 1, 2, 3, 4, 5, 2 },
Output: 5, 2
*/
            int[] arr = new int[] { 16, 17, 4, 3, 5, 2 };
            int n = arr.Length;

            int max_from_right = arr[n - 1];

            // Rightmost element is always leader
            Console.Write(max_from_right + " ");

            for (int i = n - 2; i >= 0; i--)
            {
                if (max_from_right < arr[i])
                {
                    max_from_right = arr[i];
                    Console.Write(max_from_right + " ");
                }
            }
        }
        public static int[] MergeArray(int[, ] array, int N, int[] output)
        {
            // Sorting the 2D array by coverting to 1D and Sorting the code.
            var col = array.GetLength(1);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < col; j++)
                    //Convert 2D Array to 1D Array and Sort the Array .
                    output[i+j] = array[i, j];
            }

            Array.Sort(output);
            return output;
        }
        public static int[][] MakeZeroJagged(int[][] array)
        {
            // If the column or row has one occurence of Zero then make entire row and column as Zero using Jagged Array
            HashSet<int> row = new HashSet<int>();
            HashSet<int> col = new HashSet<int>();
            var noOfRows = array.GetLength(0); 
         

            for (int i = 0; i < noOfRows; i++)
            {
                var noOfCols = array[i].Length;

                for (int j = 0; j < noOfCols; j++)
                {
                    if (array[i] [j] == 0)
                    {
                        row.Add(i);
                        col.Add(j);
                    }
                }
            }

            for (int i = 0; i < noOfRows; i++)
            {
                var noOfCols = array[i].Length;

                for (int j = 0; j < noOfCols; j++)
                {
                    if (row.Contains(i) || row.Contains(j))
                    {
                        // Making entire row and column as Zero if it has one occurence of Zero.
                        array[i][ j] = 0;
                    }
                }
            }


            return array;

        }
        public static int[,]  MakeZero(int[,] array)  
        {
            // If the column or row has one occurence of Zero then make entire row and column as Zero using MultiDimensional Array
            HashSet<int> row = new HashSet<int>();
            HashSet<int> col = new HashSet<int>();
             var noOfRows = array.GetLength(0);
            var noOfCols = array.GetLength(1);

            for (int i = 0; i < noOfRows; i++)
            {
                for (int j= 0; j < noOfCols; j++)
                {
                    if (array[i,j] == 0)
                    {
                        row.Add(i);
                        col.Add(j);
                    }
                }
            }


            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 0; j < noOfCols; j++)
                {
                    if (row.Contains(i)|| row.Contains(j))
                    {
                        
                        array[i,j] = 0;
                    }
                }
            }


            return array;

        } 
        public static bool PrimeNumber(int n)
        {
            // 2,3,5,7,11,13,17
            //Number Divisible by itself not another number
            int i, m = 0, flag = 0;
            m = n / 2; // we dont need to do for all the case so we are restricting till half the number
            // eg : 17 we need to check from 2 ,3,4,5,6,7,8,9,10,11,12,131,14,15,16 are divisible so instead we do half
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0) // number is divisible then its not prime number.
                { 
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return true;
            return false;
        }
        public static int LastStoneWeight(int[] stones)
        {
            // 1) check highest 2 number same or different
            //2 ) same remoe both from array
            //3) Not same check difference and assign to second array. remove the Highest element number.
            List<int> ls = stones.ToList();
            while (ls.Count > 1)
            {
                ls = ls.OrderByDescending(s => s).ToList();
                int a = ls[0];
                int b = ls[1];
                if (a == b)
                {
                    ls.RemoveAt(1);
                    ls.RemoveAt(0);
                }
                else
                {
                    ls[1] = a - b;
                    ls.RemoveAt(0);
                }
            }
            return ls.Count > 0 ? ls.First() : 0;
        }
        public static void MergeSortArray()
        {
            /* Already 2 array are sorted then we can just concatenate 2 array based on the merge.
            function mergeSortedArrays(arr1, arr2)
            {
                let merged = [];
                const mergedLength = arr1.length + arr2.length;
                let arr1Index = 0;
                let arr2Index = 0;
                for (let i = 0; i < mergedLength; i++)
                {
                    if (arr1[arr1Index] === undefined)
                    {
                        merged.push(arr2[arr2Index]);
                        arr2Index++
                    }
                    else if (arr2[arr2Index] === undefined)
                    {
                        merged.push(arr1[arr1Index]);
                        arr1Index++
    }
                    else if (arr1[arr1Index] <= arr2[arr2Index])
                    {
                        merged.push(arr1[arr1Index]);
                        arr1Index++
    }
                    else
                    {
                        merged.push(arr2[arr2Index])
      arr2Index++
    }
                }
                console.log(merged)
  return merged;
            }
            mergeSortedArrays([0, 3, 4, 31], [3, 4, 6, 30]);
            */
        }
        public static bool ContainCommonItem(string[] source, string[] target)
        {

            //var temp3 = new string[] { "h1i", "hello" };
            //var temp4 = new string[] { "hi", "how", "Are", "you" };
            // like intersect
            Dictionary<string, bool> map = target.ToDictionary(x => x, x => true);

            for (int i = 0; i < source.Length; i++)
            {
                if (map.ContainsKey(source[i]))
                {
                    return true;
                };
            }
            return false;
        }
        public static int RecurringNumber(int[] nums)
        {
            // IF THE ARRAY HAS DUPLICATES THEN RETURN FIRST DUPLICATE POSITION
            int i = 0;
  
            var map = new HashSet<int>();

            while( i < nums.Length)
            {

                if (!map.Contains(nums[i]))
                {
                    map.Add(nums[i]);
                }
                else if (map.Contains(nums[i]))
                {
                    return nums[i];
                }
               
                i++;
            }
 
            return 0;

        }
        public static  int MaxSubArray(int[] nums)
        {
        //      Input: nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        //Output: 6
            int max = nums[0];
            int tmp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                tmp += nums[i];
                if (tmp > max)
                {
                    max = tmp;
                }
                if (tmp < 0)
                {
                    tmp = 0;
                }
            }
            return max;
        }
        public static void MoveZeroes(int[] nums)
        {
            int lastZeroPos = 0;
            // MOVE THE ZEROS TO LAST by TRAVERSE THE ARRAY
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    (nums[lastZeroPos], nums[i]) = (nums[i], nums[lastZeroPos]);
                    lastZeroPos++;
                }
            }
        }
        public static  int LengthOfLongestSubstring(string s)
        {
            //abcabcbb
            // Here  we need to find the Longest string without repeating 
            //if you find remove first occurence .
            var charSet = new HashSet<char>();
            int left = 0, right = 0, maxLength = 0;
            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, charSet.Count);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }
            return maxLength;
        }
        public static int ReverseNumber(int x)
        {
            // scenario - 1 giving the -123 => -321
                int ans = 0;
            int sign = Math.Sign(x); // - 1
            int absNumber = Math.Abs(x); // without negative sign
            int remainder = 0;

          while (absNumber > 0)
            {
                remainder = absNumber % 10;
                ans = ans * 10 + remainder;
                absNumber = absNumber / 10;
            }

          if (ans > int.MaxValue)  
                return 0;
            return ans * sign ;

        }
        public static int ReverseWithSwap(int x)
        {
            var sign = Math.Sign(x);
            var absolute = Math.Abs(x); 
            var ConvertString = absolute.ToString().ToArray();
            var j = ConvertString.Length - 1;
            int i = 0;
            while(i < j)
            {
                char temp = ConvertString[i];
                ConvertString[i] = ConvertString[j];
                ConvertString[j] = temp;
                i++;
                j--;
            }
            int.TryParse(ConvertString, out int result);
            return result* sign;
        }
        public static int MaxWaterContainerStoredBasedonArray(int[] height)
        {
            // Find the Max between either side of the array 
            // whichever is smaller then move to next level 
            // calculate the water based on Minimum value 
            // compare the water container with old and new which ever is larger that will be the max
            int max =int.MinValue;
            int startIndex = 0;
            int endIndex = height.Length - 1; // LAST VALUE

            while(startIndex < endIndex)
            {
                max = Math.Max(max, Math.Min(height[startIndex], height[endIndex]) * (endIndex - startIndex));

                if (height[startIndex] > height[endIndex])
                    endIndex--;
                else startIndex--;
            }
            return max;
        }
        public static bool IsArmStrongNumber(int num)
        {
            int sum = 0;
            int number = num;
            // Armstrong Number is (1^3) + ( 5^3 ) + ( 3^3) = Given Number
            while ( number > 0 )
            {
                number = number % 10;
                sum = sum + number ^ 3;
                number = number / 10;
            }
            if (sum != number)
                return false;
            return true;
        }
        public static void Convert2DArray1D()
        {
            int[,] arr = { { 1, 3, 5, 7 }, { 2, 4, 6, 8 }, { 0, 9, 10, 11 } };

            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            int[] combinedArray = new int[rows * cols];
            int combinedArrayPosition = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    combinedArray[combinedArrayPosition] = arr[i, j];
                    combinedArrayPosition++;
                }
            }
            Array.Sort(combinedArray);

            foreach (int i in combinedArray)
            {
                Console.WriteLine(i);
            }

        }
        public static int FindKthPositiveV1(int[] arr , int k)
        {
            var arrayMax = arr.Max(); /// 1,2,3,4,5
            var max = k +arrayMax;
            max =  k + arrayMax;
            // IF GIVEN NUMBER IS NOT BEYOND 
            var MissedElement = Enumerable.Range(1, max).Except(arr);
            return MissedElement.ToArray()[k -1 ];
        }
        public static int FindKthPositive(int[] arr, int k)
        {
            /* Input: arr = [2,3,4,7,11], k = 5
Output: 9
            Explanation: The missing positive integers are [1,5,6,8,9,10,12,13,...]. The 5th missing positive integer is 9.
            Input: arr = [1,2,3,4], k = 2
Output: 6
Explanation: The missing positive integers are [5,6,7,...]. The 2nd missing positive integer is 6.

             * 
             */
            int l = 0, h = arr.Length - 1, mid;
            while (l <= h)
            {
                mid = l + (h - l) / 2;
                if ((arr[mid] - (mid + 1)) < k)
                {
                    l = mid + 1;
                }
                else
                {
                    h = mid - 1;
                }
            }
            return l + k;
        }

    }
}
