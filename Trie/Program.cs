using System;

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

        }
    }
}
