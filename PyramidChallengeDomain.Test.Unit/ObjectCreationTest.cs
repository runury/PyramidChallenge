using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PyramidChallengeDomain.Test.Unit
{
    [TestClass]
    public class ObjectCreationTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid input")]
        public void GivenNullInput_WhenCreatingPyramid_ArgumentExceptionIsThrown()
        {
            //Assert
            new Pyramid(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Invalid input")]
        public void GivenNoInput_WhenCreatingPyramid_ArgumentExceptionIsThrown()
        {
            //Assert
            new Pyramid(new int[0]);
        }

        [TestMethod]
        public void GivenAsymmetricInput_WhenCreatingPyramid_AsymmetricPyramidIsCreated()
        {
            //Act
            var pyramid = new Pyramid(TestEntities.AsymmetricInput);

            //Assert
            CollectionAssert.AreEqual(new[] { false, false, false, false, false, false, true, true }, pyramid.Nodes.Select(node => node.IsBottomNode).ToArray());
        }

        [TestMethod]
        public void GivenMaximumInputValues_WhenCreatingPyramid_PyramidIsCreated()
        {
            //Act
            var pyramid = new Pyramid(TestEntities.BigValueInput);

            //Assert
            Assert.AreEqual(1, pyramid.Root.Children.Count);
        }

        [TestMethod]
        public void GivenInputValues_WhenCreatingPyramid_PyramidNodesHasSortedChildren()
        {
            //Act
            var pyramid = new Pyramid(TestEntities.HugeTestInput);
            var nodesWithTwochildren = pyramid.Nodes.Where(node => node.Children.Count == 2);

            //Assert
            foreach (var node in nodesWithTwochildren)
            {
                Assert.IsTrue(node.Children.First().Weight >= node.Children.Last().Weight);
            }
        }

        [TestMethod]
        public void GivenOneMillionInputValues_WhenCreatingPyramid_PyramidIsCreated()
        {
            //Arrange
            int[] longInput = GetListOfInts(1000000).ToArray();

            //Act
            var pyramid = new Pyramid(longInput);

            //Assert
            Assert.AreEqual(1000000, pyramid.Nodes.Count);

            static List<int> GetListOfInts(int count)
            {
                var result = new List<int>();
                Random rand = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < count; i++)
                    result.Add(rand.Next(1, 1000));
                
                return result;
            }
        }

        [TestMethod]
        public void GivenLargeInput_WhenCreatingPath_PathIsInitializedCorrectly()
        {
            //Act
            var path = new Path(TestEntities.SmallTestInput.Select(val => new Node(val)).ToList());
            
            //Assert
            Assert.AreEqual(TestEntities.SmallTestInput.Length, path.Count);
            Assert.AreEqual(47, path.GetTotalWeight());
            Assert.AreEqual(string.Join(", ", TestEntities.SmallTestInput), path.ToString());
        }

        [TestMethod]
        public void GivenNoInput_WhenCreatingPath_PathIsEmpty()
        {
            //Act
            var path = new Path();

            //Assert
            Assert.IsFalse(path.Any());
            Assert.AreEqual(0, path.GetTotalWeight());
            Assert.AreEqual(string.Empty, path.ToString());
        }
    }
}
