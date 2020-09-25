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
            tree.Add("hip");

        }
    }
}
