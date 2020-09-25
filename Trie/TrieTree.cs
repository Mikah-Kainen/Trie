using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Trie
{
    public class TrieTree
    {
        TrieNode RootNode;

        public TrieTree()
        {
            RootNode = new TrieNode('$');
        }

        public bool Add(string newWord)
        {
            return Add(newWord, RootNode, 0);
        }

        private bool Add(string newWord, TrieNode currentNode, int currentIndex)
        {
            if(currentIndex == newWord.Length)
            {
                bool returnValue = currentNode.isEnd;
                currentNode.isEnd = true;
                return returnValue;
            }
            else if(currentNode.Children != new Dictionary<char, TrieNode>() && currentNode.Children.ContainsKey(newWord[currentIndex]))
            {
                return Add(newWord, currentNode.Children[newWord[currentIndex]], currentIndex + 1);
            }
            else
            {
                return Add(newWord, new TrieNode(newWord[currentIndex]), currentIndex + 1);
            }
        }
        

    }
}
