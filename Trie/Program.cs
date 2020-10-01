using System;
using System.Collections.Generic;
using System.Text.Json;

namespace Trie
{

    class A
    {
        public string name { get; set; }
        public int x { get; set; }
        public A(int x)
        {
            this.x = x;
        }

        public A(int x, string name)
        {
            this.x = x;
            this.name = name;
        }

        public A()
        {

        }
        public void DoSomething()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //using System.IO; (read the file) ../ to go back a level
            TrieTree tree = new TrieTree();

            tree.Add("hello");
            tree.Add("jello");
            tree.Add("jelly");
            tree.Add("hi");
            tree.Add("help");
            bool result1 = tree.Add("hip");

            bool result2 = tree.Remove("hi");
            bool result3 = tree.Remove("bye");
            bool result4 = tree.Add("hello");

            TrieNode result5 = tree.Search("hello");
            TrieNode result6 = tree.Search("hi");
            tree.Add("hi");
            TrieNode result7 = tree.Search("hi");
            
            List<string> result8 = tree.FindMatchingPrefixes("h");
            List<string> result9 = tree.FindMatchingPrefixes("hi");
            List<string> result10 = tree.FindMatchingPrefixes("jell");

            //Type t = typeof(A);
            //A a = new A(5);
            //A b = new A(27);
            ////a.name = "John";

            ////string temp = JsonSerializer.Serialize(a, t);

            ////A thing = (A)JsonSerializer.Deserialize(temp, typeof(A));

            ////Try to serialize a list of A
            ////List<A> list = new List<A>();
            ////list.Add(a);
            ////list.Add(b);

            ////string temp = JsonSerializer.Serialize(list, typeof(List<A>));
            ////List<A> result = (List<A>)JsonSerializer.Deserialize(temp, typeof(List<A>));


            //A[] array = new A[10];
            //array[0] = new A(0, "zero");
            //array[1] = new A(72, "BoB");
            //array[2] = new A(43, "TRI");
            
            //string temp = JsonSerializer.Serialize(array, array.GetType());
            //A[] result = (A[])JsonSerializer.Deserialize(temp, array.GetType());

            //    
            //string myString = "{\"test\": \"myTest\", \"hi\":\"This is hello\"}";

            //Dictionary<string, string> dict = (Dictionary<string, string>)JsonSerializer.Deserialize(myString, typeof(Dictionary<string, string>));

            // Show JSON reading/writing, read in the dictionary words from the json file and print out definitions if its a full word, or show all word completions
            // using System.Text.Json
        }
    }
}
