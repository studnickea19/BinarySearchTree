using System;
using System.Collections;
using System.Collections.Generic;
using BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearchTreeTests
{
    [TestClass]
    public class BinaryTests
    {
        [TestMethod]
        public void Add_LesserNode_MovesLeft()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            Node expected = new Node(16);
            Node actual = new Node();

            //Act
            newTree.Add(32);
            newTree.Add(expected.data);
            actual = newTree.root.left;


            //Assert
            Assert.AreEqual(expected.data, actual.data);
        }

        [TestMethod]
        public void Add_SecondLesserNode_MovesLeft()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            Node expected = new Node(8);
            Node actual = new Node();

            //Act
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(expected.data);
            actual = newTree.root.left;


            //Assert
            Assert.AreEqual(expected.data, actual.data);
        }

        [TestMethod]
        public void CheckNode_CurrentNode_MovesLeftOrRight()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            int data = 24;

            //Act
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(64);
            int expected = newTree.root.left.data;
            int actual = newTree.CheckNode(data).data;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckNode_CurrentNode_IsRootIfEmptyNode()
        {
            //Arange
            BinaryTree newTree = new BinaryTree();
            int data = 64;

            //Act
            newTree.Add(32);
            newTree.Add(16);
            int expected = newTree.root.data;
            int actual = newTree.CheckNode(data).data;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_NodeDirections_AreCorrectForHeadNode()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(64);
            newTree.Add(8);
            newTree.Add(24);
            newTree.Add(42);
            string expected = "This is the head node.";
            string actual;
            //Act
            actual = newTree.Search(32);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_NodeDirections_AreCorrectForNoNode()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(64);
            newTree.Add(8);
            newTree.Add(24);
            newTree.Add(42);
            string expected = "The node is not in this tree";
            string actual;
            //Act
            actual = newTree.Search(82);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Search_NodeDirections_AreCorrect()
        {
            //Arrange
            BinaryTree newTree = new BinaryTree();
            newTree.Add(32);
            newTree.Add(16);
            newTree.Add(64);
            newTree.Add(8);
            newTree.Add(24);
            newTree.Add(42);
            string expected = "The node location is: right.left.!!!";
            string actual;
            //Act
            actual = newTree.Search(42);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
