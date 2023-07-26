// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//list the datastrcture
//create the datastructure
//add data to the datastructure
//read data from the datastructure
//update data in the datastructure
//delete data from the datastructure
//types with example when and where to use datasrcture
//array
//list
//dictionary
//stack
//queue
//tree
//graph
//when use array arraylist and what difference between them
//when use list and what difference between them
//when use dictionary and what difference between them
//when use stack and what difference between them
//when use queue and what difference between them
//when use tree and what difference between them
//when use graph and what difference between them
//when use linkedlist and what difference between them
//when use hashtable and what difference between them
//when use hashset and what difference between them
//when use hashmap and what difference between them
//when use hash and what difference between them
//when use hashcode and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//when use hashset and what difference between them
//with code exmaple
//when use array arraylist and what difference between them write code
//when use list and what difference between them write code
//give the code example for each datastruct
//Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.
//Example 1:
//Input: words = ["bella","label","roller"]
//Output: ["e","l","l"]
//Example 2:
//Input: words = ["cool","lock","cook"]
//Output: ["c","o"]
//Constraints:
//1 <= words.length <= 100  
//1 <= words[i].length <= 100
//words[i] consists of lowercase English letters.
//https://leetcode.com/problems/find-common-characters/
//write code for above quesgion
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
using System.Runtime.CompilerServices;

public IList<string> CommonChars(string[] words) 
 {
        var result = new List<string>();
        var dict = new Dictionary<char, int>();
        foreach(var c in words[0])
        {
            if(dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        for(int i = 1; i < words.Length; i++)
        {
            var tempDict = new Dictionary<char, int>();
            foreach(var c in words[i])
            {
                if(tempDict.ContainsKey(c))
                {
                    tempDict[c]++;
                }
                else
                {
                    tempDict.Add(c, 1);
                }
            }
            foreach(var key in dict.Keys.ToList())
            {
                if(tempDict.ContainsKey(key))
                {
                    dict[key] = Math.Min(dict[key], tempDict[key]);
                }
                else
                {
                    dict.Remove(key);
                }
            }
        }
        foreach(var key in dict.Keys)
        {
            for(int i = 0; i < dict[key]; i++)
            {
                result.Add(key.ToString());
            }
        }
        return result;
    }        
 }
 //what is genric in c# give the answer with example write code for this
 genric is a type of class or method that can be used for any data type
    public class Genric<T>
    {
        public T Add(T a, T b)
        {
            return a+b;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Genric<int> genric = new Genric<int>();
            Console.WriteLine(genric.Add(1,2));
        }
    }

//what is delegate in c# give the answer with example write code for this
delegate IsBoxed (object o);
public class Program
{
    public static void Main(string[] args)
    {
        IsBoxed ib = IsBoxed;
        Console.WriteLine(ib(1));
    }
    public static bool IsBoxed(object o)
    {
        return o is int;
    }
}
//what is interface in c# give the answer with example write code for this
interface ITest
{
    void Test();
}
public class Program : ITest
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Test();
    }
    public void Test()
    {
        Console.WriteLine("Test");
    }
}
//what is abstract class in c# give the answer with example write code for this
abstract class Test
{
    public abstract void Test();
}
public class Program : Test
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        p.Test();
    }
    public override void Test()
    {
        Console.WriteLine("Test");
    }
}
//what is hashmap hashset in c# give the answer with example write code for this
hashmap is a datastructure that store the data in key value pair and use hashcode to store the data 
in memory and hashset is a datastructure that store the data in key value pair and use hashcode to store the data in memory
difference between hashset and hashmap
hashmap is a datastructure that store the data in key value pair and use hashcode to store the data
