using BinarySearchTreeDFS;
using LeetCode;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;


var arrayOfRecurring = new int[] { 1, 2, 3, 4, 2, 5, 6 ,3};
arrayOfRecurring.ToList().Take(1);
//var temp3 = new string[] { "h1i", "hello" };
//var temp4 = new string[] { "hi", "how", "Are", "you" };
//LeetCodeClass.LengthOfLongestSubstring("daba");
//LeetCodeClass.MoveZeroes(new int[] { 0, 1, 0, 3 });
//LeetCodeClass. MaxSubArray(new int[] { -2, -1, -3, 4, -1, 2, 1, -5, 4 });

//LeetCodeClass.RecurringNumber(arrayOfRecurring);
//var temp = arrayOfRecurring.GroupBy(x => x).Where(g => g.Count() > 1).Select(x=> x.Key).FirstOrDefault();
//var temp2 = arrayOfRecurring.FindDuplicates().ToList();
//Linq way of finding
//LeetCodeClass.ContainCommonItem(temp3, temp4);
//var t = temp3.Intersect(temp4).Count() > 0;
//var primeOrNot = LeetCodeClass.PrimeNumber(11);
/*
LinkedList ls = new LinkedList(10);
ls.appendNode(11);
ls.appendNode(12);
ls.appendNode(13);
ls.appendNode(14);
ls.appendNode(15);
ls.prependNode(9);
ls.insert(3, 100);
ls.printList();
0
int[][] array = new int[3][]
{
    new int[3]{1,2,3}, 
    new int[3] {1,0,3},
    new int[3] {1,2,3}

};
var matrix = LeetCodeClass.MakeZeroJagged(array);
int[,] array1 = new int[,] { {1,2,3 }, {1,0,3 }, {1,2,3 } };
var matrix1 = LeetCodeClass.MakeZero(array1);
int[] output  = new int[9];
var output1 = LeetCodeClass.MergeArray(array1,3, output);
LeetCodeClass.printLeaders();

var newDict = new Dictionary<int, List<int>>();
newDict.Add(1, new List<int>());
newDict.Add(2, new List<int>());
newDict.Add(3, new List<int>());

if (newDict.ContainsKey(1))
{
    newDict[1].Add(2);
    newDict[1].Add(3);
}

if (newDict.ContainsKey(2))
{
    newDict[2].Add(1);
    newDict[2].Add(3);
}

if (newDict.ContainsKey(3))
{
    newDict[3].Add(1);
    newDict[3].Add(2);
}

var target = 3;

var keys = newDict[target];

foreach (var value in newDict.Values)
{
    foreach (var item in value)
    {
        Console.WriteLine(item);
    }
}

newDict.Remove(target); 
foreach ( var key in keys)
{
    newDict[key].Remove(target);
}

newDict.Remove(target);
 
foreach (KeyValuePair<int, List<int>> kvp in newDict)
{
    if (kvp.Value.Contains(target))
    {
        kvp.Value.Remove(target);
    }
}
 
foreach ( var value  in newDict.Values)
{
    foreach( var item in  value)
    {
        Console.WriteLine(item);
    }
}

 foreach ( var itemKey in dict)
{
    var stringHasEdge = new StringBuilder();
    var stringNoEdge = "no edges ";
    foreach (var item in itemKey.Value)
    {
        stringHasEdge.Append(item).Append(' ');
    }

    Console.WriteLine( $"This is Key Vertex : {itemKey.Key}  { ( string.IsNullOrEmpty(stringHasEdge.ToString())  ?   stringNoEdge :   stringHasEdge ) }");
}


//LeetCodeSolution.PersonDataTuple();
//LeetCodeSolution.bubbleSort(arrayOfRecurring);

var array = new int[] { 1, 2, 3, 4, 5,6 };
var slice1 = array[2..^3];    // array[new Range(2, new Index(3, fromEnd: true))]
var slice2 = array[..^3];     // array[Range.EndAt(new Index(3, fromEnd: true))]
var slice3 = array[2..];      // array[Range.StartAt(2)]
var slice4 = array[..];       // array[Range.All]
foreach (var item in slice1)
{
    Console.WriteLine("Slice1");
    Console.WriteLine(item);
}



Coordinate point = new Coordinate(1,2);
point = new Coordinate();
point.x = 10;
point.y = 20;
Console.Write(point.x); //output: 10  
Console.Write(point.y); //output: 20  


 

var cl = new ConstructorChild();
Console.WriteLine("COMPLETED - 1");
var cl1 = new ConstructorChild("Sridhar");
Console.WriteLine("COMPLETED - 2");
var cl2 = new ConstructorChild("Sridhar",23,100000);
Console.WriteLine("COMPLETED - 3");



var dict = new Dictionary<int, Object>();
dict.Add(1, true);
dict.TryAdd(1, true);
var dict1 = new ConcurrentDictionary<int, object>();
var list = new List<Object>();
var list1= new ConcurrentBag<Object>();
var stack = new Stack<Object>();
stack.Push(list);
var stack1 = new ConcurrentStack<Object>();
var queue   = new Queue<Object>();
queue.Enqueue(list1);
var queue1 = new ConcurrentQueue<Object>();

struct Structure
{

}
 public sealed class Base 
{
    public void test()
    {

    }
}

public class Child 
{
    public void test()
    {
        var vl = new Base();
    }
}

int[,] multi = new int [2 , 3]  { { 12, 12, 12 }, { 12, 122,12 } };
int[][] multiOne = new int[2][] { 
     new int[] { 12, 12 },
     new int[] { 12, 24}
      };
var sb1 = new StringBuilder("Blue");
var sb2 = new StringBuilder("Blue");
Console.WriteLine(sb1 ==sb2);
Console.WriteLine(sb1.Equals(sb2));
Console.WriteLine(sb2.GetType());
 

BinarySearchTree tree = new BinarySearchTree();
tree.insert(9);
tree.insert(4);
tree.insert(6);
tree.insert(20);
tree.insert(170);
tree.insert(15);
tree.insert(1);

var InOrder = tree.DFSInOrder();
DepthFirstSearch.PrintList(InOrder);
var PreOrder = tree.DFSPreOrder();
DepthFirstSearch.PrintList(PreOrder);
var PostOrder = tree.DFSPostOrder();
DepthFirstSearch.PrintList(PostOrder);
 


string newstring = "mad1";
Console.WriteLine(LeetCodeSolution.Palindrome(newstring));
int[] arr1 = new int[] { 12, 13, 17, 19 };
int[] arr2 = new int[] { 14, 17, 19 };

var combinedArray1= arr1.Concat(arr2).ToArray();
var combinedArray = new int[arr1.Length + arr2.Length];
 arr1.CopyTo(combinedArray, 0);
arr2.CopyTo(combinedArray, arr1.Length);

foreach (int i in combinedArray)
{ Console.WriteLine(i); }
 

int x = 100;
var sign = Math.Sign(x);
x = Math.Abs(x);

char[] chars = x.ToString().ToCharArray();
Array.Reverse(chars);
Console.WriteLine(LeetCodeClass.IsArmStrongNumber(153));

Console.WriteLine(LeetCodeClass.ReverseNumber(-123));


char[][] grid1 = new char[][]
{
    new char[] {'1' ,'1', '1', '1', '0'    },
    new char[] { '1', '1', '0', '0' ,'0'  },
    new char[] { '1' ,'1', '0', '1', '1' },
       new char[] { '0' ,'0', '0', '1', '0' }
};

char[][] grid = new char[][]
{
    new char[] {'1' ,'1'},
      new char[] {'1' ,'0'   }
};
Console.WriteLine(Solution.NumIslands(grid));

*/


LeetCodeClass.LengthOfLongestSubstring("abcabcbb");