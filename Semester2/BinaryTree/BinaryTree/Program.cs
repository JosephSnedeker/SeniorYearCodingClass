using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Insert('5');
            binaryTree.Insert('w');
            binaryTree.Insert('C');
            binaryTree.Insert('y');
            binaryTree.Insert('Z');
            binaryTree.Insert('2');
            binaryTree.Insert('7');
            binaryTree.Insert('8');
            binaryTree.Insert('9');
            binaryTree.Insert('Y');
            binaryTree.Remove('C');
            binaryTree.Print();
            
            Console.WriteLine(binaryTree.Count);
            Console.ReadKey();

        }
    }
}
