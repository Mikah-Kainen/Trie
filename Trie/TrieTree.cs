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
        
        public TrieNode Search(string targetWord)
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
                    return null;
                }
            }
            return currentNode;
        }

        public List<string> FindMatchingPrefixes(string preSearched)
        {
            TrieNode currentNode = Search(preSearched);
            List<TrieNode> endingNodes = new List<TrieNode>();
            Dictionary<TrieNode, TrieNode> parentMap = new Dictionary<TrieNode, TrieNode>();
            Stack<TrieNode> stack = new Stack<TrieNode>();
            stack.Push(currentNode);
            parentMap.Add(currentNode, RootNode);

            (List<TrieNode> endingNodes, Dictionary<TrieNode, TrieNode> parentMap) updatedInfo = FMP(endingNodes, parentMap, stack);
            endingNodes = updatedInfo.endingNodes;
            parentMap = updatedInfo.parentMap;

            List<string> returnList = new List<string>();
            List<char> futureString;
            foreach(TrieNode node in endingNodes)
            {
                futureString = new List<char>();
                currentNode = node;
                futureString.Add(currentNode.value);
                while (!parentMap[currentNode].Equals(RootNode))
                {
                    currentNode = parentMap[currentNode];
                    futureString.Add(currentNode.value);
                }
                for(int i = preSearched.Length - 2; i >= 0; i --)
                {
                    futureString.Add(preSearched[i]);
                }
                futureString.Reverse();
                returnList.Add(new string(futureString.ToArray()));
            }
            return returnList;
        }

        private (List<TrieNode> endingNodes, Dictionary<TrieNode, TrieNode> parentMap) FMP(List<TrieNode> endingNodes, Dictionary<TrieNode, TrieNode> parentMap, Stack<TrieNode> stack)
        {
            if(stack.Count == 0)
            {
                return (endingNodes, parentMap);
            }
            TrieNode currentNode = stack.Pop();
            if(currentNode.isEnd)
            {
                endingNodes.Add(currentNode);
            }
            foreach(KeyValuePair<char, TrieNode> pair in currentNode.Children)
            {
                parentMap.Add(pair.Value, currentNode);
                stack.Push(pair.Value);
            }

            return FMP(endingNodes, parentMap, stack);
        }

    }
}
