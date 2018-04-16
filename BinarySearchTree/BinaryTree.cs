using System;
namespace BinarySearchTree
{
    public class BinaryTree
    {
        Node root;
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
                Node currentNode = CheckNodeToAdd(nodeToAdd);

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

        public Node CheckNodeToAdd(Node nodeToAdd)
        {
            Node currentNode;
            if(nodeToAdd.data < root.data)
            {
                currentNode = CheckLeftNode(nodeToAdd.data);
            }
            else
            {
                currentNode = CheckRightNode(nodeToAdd.data);
            }
            return currentNode;
        }

        public Node CheckLeftNode(int data)
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

        public Node CheckRightNode(int data)
        {
            Node currentNode = root;
            while (currentNode.left != null && currentNode.right != null)                   
            {
                if (data < currentNode.data)          
                {
                    currentNode = currentNode.left;             
                }
                else if (
                    data > currentNode.data)     
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
                while (currentNode.left != null)                    //If left node is occupied
                {
                    if (data == currentNode.data)
                    {
                        nodeDirections += ".";
                    }
                    else if (data < currentNode.data)                    //& checkItem is less than current Node
                    {
                        nodeDirections += "left.";
                        currentNode = currentNode.left;             //move left
                    }
                    else if (data > currentNode.data)               //& checkItem is greater than current Node
                    {
                        nodeDirections += "right.";
                        currentNode = currentNode.right;            //move right
                    }
                }
                if (currentNode.left == null && data != currentNode.data)
                {
                    nodeDirections = "The node is not in this tree";
                }
            }
            else if (data > currentNode.data)
            {
                while (currentNode.right != null)                   //If right node is occupied
                {
                    if (data == currentNode.data)
                    {
                        return nodeDirections;
                    }
                    else if (data < currentNode.data)
                    {
                        nodeDirections += "left.";
                        currentNode = currentNode.left;             //move left
                    }
                    else if (data > currentNode.data)               //& nodeToAdd is greater than current Node
                    {
                        nodeDirections += "right.";
                        currentNode = currentNode.right;               //move right
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



//public string Search(int data)
//{
//    Node currentNode = head;
//    string nodeDirections = "The node location is: ";

//    if (head.data == data)
//    {
//        nodeDirections = "This is the head node";
//    }

//    else
//    {
//        while (currentNode.left != null)
//        {
//            if (currentNode.left.data == data)
//            {
//                nodeDirections += ".";
//            }
//            else if (currentNode.left.data < data)
//            {
//                nodeDirections += ";
//            }
//            else if (currentNode.next.data > data)
//            {
//                nodeDirections += currentNode.direction;
//            }
//            currentNode = currentNode.next;
//        }
//        if (currentNode.next == null)
//        {
//            nodeDirections = "The node is not in this list";
//        }
//    }
//    return nodeDirections;
//}