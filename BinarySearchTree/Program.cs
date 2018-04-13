using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree newTree = new BinaryTree();
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(64);
            //linkedList.Add(128);
            //linkedList.Add(8);
            //linkedList.Add(1);
            //linkedList.Add(164);
            //linkedList.Add(24);
            //linkedList.Add(42);
            Console.WriteLine(newTree.binaryTree.root.data);
            Console.WriteLine(newTree.binaryTree.root.right.data);
            Console.WriteLine(newTree.binaryTree.root.left.data);
            Console.ReadKey();
        }
    }
}
