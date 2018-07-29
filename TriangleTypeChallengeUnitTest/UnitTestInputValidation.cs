using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTypeLibrary.Core.Implementation.Factory;
using TriangleTypeLibrary.Core.Implementation.Repository;
using TriangleTypeLibrary.Core.Interfaces.Repository;
using TriangleTypeLibrary.Cross.Helpers.Validation.Implementation;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeChallengeUnitTest
{
    [TestClass]
    public class UnitTestInputValidation
    {
        private readonly ITriangleRepository _triangle;

        public UnitTestInputValidation()
        {
            _triangle = new TriangleFactory<TriangleRepository>().GetInstance();
        }

        [TestMethod]
        public void TestMethod_Validate_Axises_Values_When_Grater_Than_Zero()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 4.3,
                Height = 5,
                Base = 11
            };
            var res = new NumbericValidation().GreaterThanZero(_triangle.TriangleEntity);
            Assert.AreEqual(string.Empty, res);
        }
        [TestMethod]
        public void TestMethod_Validate_Axises_Values_When_Less_Than_Zero()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = -3,
                Height = 5,
                Base = 11
            };
            var res = new NumbericValidation().GreaterThanZero(_triangle.TriangleEntity);
            Assert.AreNotEqual(string.Empty, res);
        }

        [TestMethod]
        public void TestMethod_Validate_Axises_Against_Unknown_Triangle_Type()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 10,
                Height = 21,
                Base = 30
            };
            var res = new TriangleAxisesValidation().AxisesValidForTriangle(_triangle.TriangleEntity); //Two sides summation > third side.
            Assert.AreEqual(string.Empty, res);
        }

        [TestMethod]
        public void TestMethod_Invalidate_Axises_Against_Unknown_Triangle_Type()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 1,
                Height = 1,
                Base = 10
            };
            var res = new TriangleAxisesValidation().AxisesValidForTriangle(_triangle.TriangleEntity); //Two sides summation > third side.
            Assert.AreNotEqual(string.Empty, res);
        }
    }
}