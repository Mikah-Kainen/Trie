using System;
using System.Collections.Generic;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
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

            // Show JSON reading/writing, read in the dictionary words from the json file and print out definitions if its a full word, or show all word completions
            // using System.Text.Json
        }
    }
}
