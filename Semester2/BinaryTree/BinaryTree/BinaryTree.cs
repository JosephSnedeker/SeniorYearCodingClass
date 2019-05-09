using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        public Node Root { get; set; }



        public int height { get; set; }



        public int Count { get { return CountRecursive(Root); } }
        private int CountRecursive(Node node)
        {
            int count = 1;
            if (node.LeftChild != null)
            {
                
                count += CountRecursive(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                
                 count += CountRecursive(node.RightChild);
            }
            return count;
                
            
        }
        public void Insert(char character)
        {
            if (Root == null)
            {
                Root = new Node(character);
            }
            else
            {
                Insert(Root, character);
            }
        }
        private void Insert(Node node, char character)
        {
            if (character >= node.Value && node.RightChild == null)
            {
                node.RightChild = new Node(character);
                return;
            }
            if (character < node.Value && node.LeftChild == null)
            {
                node.LeftChild = new Node(character);
                return;
            }
            if (character >= node.Value)
            {
                Insert(node.RightChild, character);
            }
            if (character <= node.Value)
            {
                Insert(node.LeftChild, character);
            }
        }
        public void Remove(char character)
        {
           
            
            Remove(Root, character);
            
        }
        private Node Remove(Node node, Char character)
        {
            if (node.Value == character)
            {
                node.Value = Remove2(node.RightChild).Value;
                return node;
            }
            else
            {
                if (character < node.Value && node.LeftChild != null)
                {
                    return Remove(node.LeftChild, character);
                }
                else if (character > node.Value && node.RightChild != null)

                {
                    return Remove(node.RightChild, character);
                }
            }
            
            
        }
        private Node Remove2(Node node)
        {
            if (node.LeftChild != null)
            {
                return Remove2(node.LeftChild);
            }
            else
            {
                return node;
            }
        }

        public bool Search(Char character)
        {
            if (Root == null)
            {
                return false;
            }
            else
            {
                return Search(character, Root);
            }
        }

        private bool Search(Char character, Node node)
        {
            if (node.Value == character)
            {
                return true;
            }
            else
            {
                if (character < node.Value && node.LeftChild != null)
                {
                    return Search(character, node.LeftChild);
                }
                else if (character > node.Value && node.RightChild != null)
                    
                {
                    return Search(character, node.RightChild);
                }
            }
            return false;
        }
        public void PreOrderPrint()
        {

        }
        private void PreOrderPrint(Node node)
        {

        }
        public void InOrderPrint()
        {

        }
        private void InOrderPrint(Node node)
        {

        }
        public void PostOrderPrint()
        {

        }
        private void PostOrderPrint(Node node)
        {

        }
        public void Print()
        {
            BinaryTreePrinter.printNode(Root);
        }


    }
}
