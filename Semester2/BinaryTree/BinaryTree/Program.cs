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
            binaryTree.Print();
            Console.WriteLine(binaryTree.Search('7'));
            Console.WriteLine(binaryTree.Count);
            Console.ReadKey();

        }
    }
}
