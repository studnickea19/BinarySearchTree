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
            newTree.Add(128);
            newTree.Add(8);
            newTree.Add(1);
            newTree.Add(164);
            newTree.Add(24);
            newTree.Add(42);
            string print = newTree.Search(42);
            Console.WriteLine(print);
            string print2 = newTree.Search(24);
            Console.WriteLine(print2);
            string print3 = newTree.Search(91);
            Console.WriteLine(print3);
            string print4 = newTree.Search(32);
            Console.WriteLine(print4);
            Console.ReadKey();
        }
    }
}
