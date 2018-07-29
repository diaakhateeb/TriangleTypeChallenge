using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTypeLibrary.Core.Enums;
using TriangleTypeLibrary.Core.Implementation.Factory;
using TriangleTypeLibrary.Core.Implementation.Repository;
using TriangleTypeLibrary.Core.Interfaces.Repository;
using TriangleTypeLibrary.Model.Entities;

namespace TriangleTypeChallengeUnitTest
{
    [TestClass]
    public class UnitTestGetTriangleType
    {
        private readonly ITriangleRepository _triangle;

        public UnitTestGetTriangleType()
        {
            try
            {
                _triangle = new TriangleFactory<TriangleRepository>().GetInstance();
            }
            catch (NullReferenceException nullRefEx)
            {
                throw nullRefEx;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [TestMethod]
        public void TestMethod_Get_Triangle_Type_Equilateral()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 8,
                Height = 8,
                Base = 8
            };
            var triangleTypeRes = _triangle.GetTriangleType();
            Assert.AreEqual(TriangleType.Equilateral, triangleTypeRes);
        }

        [TestMethod]
        public void TestMethod_Get_Triangle_Type_Equilateral_Against_Isosceles()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 18,
                Height = 18,
                Base = 8
            };
            var triangleTypeRes = _triangle.GetTriangleType();
            Assert.AreNotEqual(TriangleType.Equilateral, triangleTypeRes);
        }

        [TestMethod]
        public void TestMethod_Get_Triangle_Type_Equilateral_Against_Scalene()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 18,
                Height = 80,
                Base = 8
            };
            var triangleTypeRes = _triangle.GetTriangleType();
            Assert.AreNotEqual(TriangleType.Equilateral, triangleTypeRes);
        }

        [TestMethod]
        public void TestMethod_Get_Triangle_Type_Isosceles_Against_Scalene()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 18,
                Height = 80,
                Base = 80
            };
            var triangleTypeRes = _triangle.GetTriangleType();
            Assert.AreEqual(TriangleType.Isosceles, triangleTypeRes);
        }

        [TestMethod]
        public void TestMethod_Get_Triangle_Type_Scalene()
        {
            _triangle.TriangleEntity = new TriangleEntity
            {
                Length = 18,
                Height = 80,
                Base = 80
            };
            var triangleTypeRes = _triangle.GetTriangleType();
            Assert.AreNotEqual(TriangleType.Scalene, triangleTypeRes);
        }
    }
}
