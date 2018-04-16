using System;
namespace BinarySearchTree
{
    public class BinaryTree
    {
        public Node root;
        public BinaryTree()
        {
            this.root = null;
        }

        public void Add(int data)
        {
            Node nodeToAdd = new Node(data);

            if (root == null)
            {
                root = nodeToAdd;
            }
            else
            {
                Node currentNode = CheckNode(nodeToAdd.data);

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

        public Node CheckNode(int data)
        {
            Node currentNode = root;
            while (currentNode.left !=null && currentNode.right !=null)                    
            {
                if (data < currentNode.data)          
                {
                    currentNode = currentNode.left;             
                }
                else if (data > currentNode.data)     
                {
                    currentNode = currentNode.right;            
                }

            }
            return currentNode;
        }

        public string Search(int data)
        {
            //if search is greater than node go right
            //if it's less than node go left
            //do that until there's no more left or right

            string nodeDirections = "The node location is: ";
            Node currentNode = root;
            if(root.data == data)
            {
                nodeDirections = "This is the head node.";
            }
            else if (data < currentNode.data)
            {
                while (currentNode.left != null)                    
                {
                    if (data == currentNode.data)
                    {
                        nodeDirections += ".";
                    }
                    else if (data < currentNode.data)                    
                    {
                        nodeDirections += "left.";
                        currentNode = currentNode.left;             
                    }
                    else if (data > currentNode.data)               
                    {
                        nodeDirections += "right.";
                        currentNode = currentNode.right;            
                    }
                }
                if (currentNode.left == null && data != currentNode.data)
                {
                    nodeDirections = "The node is not in this tree";
                }
            }
            else if (data > currentNode.data)
            {
                while (currentNode.right != null)                   
                {
                    if (data == currentNode.data)
                    {
                        return nodeDirections;
                    }
                    else if (data < currentNode.data)
                    {
                        nodeDirections += "left.";
                        currentNode = currentNode.left;             
                    }
                    else if (data > currentNode.data)               
                    {
                        nodeDirections += "right.";
                        currentNode = currentNode.right;               
                    }
                }
                if (currentNode.right == null && data != currentNode.data)
                {
                    nodeDirections = "The node is not in this tree";
                }
            }
            return nodeDirections;
        }
    }
}