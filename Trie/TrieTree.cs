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
            TrieNode currentNode = RootNode;
            foreach(char letter in newWord)
            {
                if(!currentNode.Children.ContainsKey(letter))
                {
                    currentNode.AddNewChild(letter);
                }
                currentNode = currentNode.Children[letter];
            }
            if (!currentNode.isEnd)
            {
                currentNode.isEnd = true;
                return true;
            }
            return false;
        }

        public bool Remove(string targetWord)
        {
            TrieNode currentNode = RootNode;
            foreach(char letter in targetWord)
            {
                if(currentNode.Children.ContainsKey(letter))
                {
                    currentNode = currentNode.Children[letter];
                }
                else
                {
                    return false;
                }
            }
            currentNode.isEnd = false;
            return true;
        }
        

    }
}
