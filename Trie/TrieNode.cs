using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Trie
{
    public class TrieNode
    {
        public char value { get; private set; }

        public bool isEnd { get; set; }

        public Dictionary<char, TrieNode> Children { get; private set; }
        public TrieNode(char value)
        {
            this.value = value;
            isEnd = false;
            Children = new Dictionary<char, TrieNode>();
        }

        public bool AddNewChild(char value)
        {
            if(!Children.ContainsKey(value))
            {
                Children.Add(value, new TrieNode(value));
                return true;
            }
            return false;
        }
    }
}
