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
            actual = newTree.binaryTree.root.left;


            //Assert
            Assert.AreEqual(expected.data, actual.data);
        }


    }
}
