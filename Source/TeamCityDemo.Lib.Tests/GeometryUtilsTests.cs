using System;
using NUnit.Framework;

namespace TeamCityDemo.Lib.Tests
{
    [TestFixture]
    public class GeometryUtilsTests
    {
        [Test]
        public void GetSquareArea_Simple()
        {
            //arrange
            var utils = new GeometryUtils();

            //act
            decimal result = utils.GetSquareArea(5);

            //assert
            Assert.AreEqual(40, result);
        }

        [Test]
        public void GetCircleArea_Simple()
        {
            //arrange
            var utils = new GeometryUtils();

            //act
            decimal result = utils.GetCircleArea(10);

            //assert
            Assert.AreEqual(Math.Round(Math.PI*100, 2), result);

        }
    }
}
