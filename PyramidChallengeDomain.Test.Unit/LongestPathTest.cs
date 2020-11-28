using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace PyramidChallengeDomain.Test.Unit
{
    [TestClass]
    public class LongestPathTest
    {
        [TestMethod]
        public void GivenSmallPyramid_WhenCalculatingLongestPath_ThenExpectedPathIsFound()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.SmallTestInput);
            
            //Act
            var longestPath = pyramid.GetLongestPath();

            //Assert
            Assert.AreEqual(16, longestPath.GetTotalWeight());
            CollectionAssert.AreEqual(new int[] { 1, 8, 5, 2 }, longestPath.Select(node => node.Weight).ToArray());
            Assert.AreEqual("1, 8, 5, 2", longestPath.ToString());
        }

        [TestMethod]
        public void GivenLargePyramid_WhenCalculatingLongestPath_ThenExpectedPathIsFound()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.LargeTestInput);
            
            //Act
            var longestPath = pyramid.GetLongestPath();

            //Assert
            Assert.AreEqual(8186, longestPath.GetTotalWeight());
            CollectionAssert.AreEqual(new int[] { 215, 192, 269, 836, 805, 728, 433, 528, 863, 632, 931, 778, 413, 310, 253 }, longestPath.Select(node => node.Weight).ToArray());
            Assert.AreEqual("215, 192, 269, 836, 805, 728, 433, 528, 863, 632, 931, 778, 413, 310, 253", longestPath.ToString());
        }

        [TestMethod]
        public void GivenPyramidWithNegativeWeights_WhenCalculatingLongestPath_ThenLongestPathIsFound()
        {
            //Arrange
            int[] negativeInput = TestEntities.SmallTestInput.Select(val => -val).ToArray();
            var pyramid = new Pyramid(negativeInput);

            //Act
            var longestPath = pyramid.GetLongestPath();

            //Assert
            Assert.AreEqual(-14, longestPath.GetTotalWeight());
            CollectionAssert.AreEqual(new int[] { -1, -8, -1, -4 }, longestPath.Select(node => node.Weight).ToArray());
            Assert.AreEqual("-1, -8, -1, -4", longestPath.ToString());
        }

        [TestMethod]
        public void GivenPyramidWithNoValidPath_WhenCalculatingLongestPath_ThenNoPathIsFound()
        {
            //Arrange
            int[] onlyEvenInput = TestEntities.SmallTestInput.Select(val => val % 2 == 1 ? val + 1 : val ).ToArray();
            var pyramid = new Pyramid(onlyEvenInput);
            
            //Act
            var longestPath = pyramid.GetLongestPath();

            //Assert
            Assert.AreEqual(0, longestPath.GetTotalWeight());
            CollectionAssert.AreEqual(new int[] { }, longestPath.Select(node => node.Weight).ToArray());
            Assert.AreEqual("", longestPath.ToString());
            pyramid.Nodes.ForEach(node => Assert.AreEqual(0, node.Children.Count));
        }

        [TestMethod]
        public void GivenAsymmetricPyramid_WhenCalculatingLongestPath_OnlyValuesFromBottomRowIsUsed()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.AsymmetricInput);

            //Act
            var longestPath = pyramid.GetLongestPath();

            //Assert
            Assert.AreEqual(16, longestPath.GetTotalWeight());
            CollectionAssert.AreEqual(new int[] { 1, 4, 3, 8 }, longestPath.Select(node => node.Weight).ToArray());
            Assert.AreEqual("1, 4, 3, 8", longestPath.ToString());
            Assert.AreEqual(2, pyramid.Nodes.Count(node => node.IsBottomNode));
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException), "Arithmetic operation resulted in an overflow.")]
        public void GivenPyramidMaximumWeights_WhenCalculatingLongestPath_OverflowExceptionIsThrown()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.BigValueInput);

            //Act
            pyramid.GetLongestPath();
        }
    }
}
