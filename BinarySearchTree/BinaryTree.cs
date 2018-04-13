using System;
namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Tree binaryTree;
        public BinaryTree()
        {
            this.binaryTree = new Tree();
        }

        public void Add(int data)
        {
            Node nodeToAdd = new Node(data);

            if (binaryTree.root == null)
            {
                binaryTree.root = nodeToAdd;
            }
            else
            {
                Node currentNode = CheckNode(binaryTree.root, nodeToAdd);

                if (nodeToAdd.data < currentNode.data)
                {
                    currentNode.left = nodeToAdd;
                }
                else
                {
                    currentNode.right = nodeToAdd;
                }  
            }
        }

        public Node CheckNode(Node root, Node nodeToAdd)
        {
            Node currentNode = root;
            while (currentNode.right != null)
            {
                if (nodeToAdd.data < currentNode.data)
                {
                    currentNode = currentNode.right;
                }
                else if (nodeToAdd.data > currentNode.data)
                {
                    currentNode = currentNode.left;
                }

            }
            return currentNode;
        }
    }
}
