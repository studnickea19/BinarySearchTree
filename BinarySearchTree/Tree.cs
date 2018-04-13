using System;
namespace BinarySearchTree
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            this.root = null;
        }



    }
}




//    else
//    {
//        while (currentNode.next == null)
//        {
//            if (nodeToAdd.data < root.data)
//            {
//                parentTree.childLessThan = nodeToAdd;
//                Tree firstChildTree = new Tree(nodeToAdd, "left");

//            }
//            else
//            {
//                parentTree.childGreaterThan = nodeToAdd;
//                Tree firstChildTree = new Tree(nodeToAdd, "right");
//            }
//        }
//    }



//    //

//    //if (nodeToAdd.data < root.data)
//    //{
//    //    head = nodeToAdd;
//    //    return;
//    //}

//    //while(currentNode.next != null)
//    //{
//    //    currentNode = currentNode.next;
//    //}

//    //currentNode.next = nodeToAdd;
//}

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
//        while (currentNode.next != null)
//        {
//            if (currentNode.next.data == data)
//            {
//                break;
//            }
//            else if (currentNode.next.data < data)
//            {
//                nodeDirections += currentNode.direction;
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