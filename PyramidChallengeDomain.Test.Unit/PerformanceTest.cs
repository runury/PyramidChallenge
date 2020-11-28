using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PyramidChallengeDomain.Test.Unit
{
    [TestClass]
    public class PerformanceTest
    {
        [TestMethod]
        public void GivenSmallInput_CalculatingLongestPath_CompletesWithinReasonableTime()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.SmallTestInput);
            var path = new Path();

            //Act
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10; i++)
            {
                path = pyramid.GetLongestPath();
            }
            watch.Stop();

            //Assert
            Assert.IsTrue(watch.ElapsedMilliseconds / 10 < 10);
            Assert.IsTrue(path.Count == 4);
        }

        [TestMethod]
        public void GivenLargeInput_CalculatingLongestPath_CompletesWithinReasonableTime()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.LargeTestInput);
            var path = new Path();

            //Act
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10; i++)
            {
                path = pyramid.GetLongestPath();
            }
            watch.Stop();

            //Assert
            Assert.IsTrue(watch.ElapsedMilliseconds / 10 < 10);
            Assert.IsTrue(path.Count == 15);
        }

        [TestMethod]
        public void GivenHugeInput_CalculatingLongestPath_CompletesWithinReasonableTime()
        {
            //Arrange
            var pyramid = new Pyramid(TestEntities.HugeTestInput);
            var path = new Path();

            //Act
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 0; i < 10; i++)
            {
                path = pyramid.GetLongestPath();
            }
            watch.Stop();

            //Assert
            Assert.IsTrue(watch.ElapsedMilliseconds / 10 < 100);
            Assert.IsTrue(path.Count == 49);
        }
    }
}
