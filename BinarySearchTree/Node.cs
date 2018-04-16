using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class Node
    {
        //MEMBER VARIABLES
        public Node left;
        public Node right;
        public int data;

        //CONSTRUCTOR
        public Node()
        {
        }

        public Node(int data)
        {
            this.left = null;
            this.right = null;
            this.data = data;
        }

        //MEMBER METHODS

    }
}
