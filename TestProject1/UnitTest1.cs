
using NUnit.Framework;
using TriangleAssignment;

namespace TriangleUnitTest
{
    [TestFixture]
    public class Tests
    {
        static string eq = "Equilateral";
        static string iso = "Isosceles";
        static string sc = "Scalene";

        [Test]
        public void TC01_To_verify_1_1_3_should_not_form_a_triangle() // To verify triangle sides 1,1,3 should not form a valid triangle
        {
            Assert.AreEqual(null, TriangleSolver.analyze(1, 1, 3)); //assert   
        }
        [Test]
        public void TC02_To_verify_0_0_0_should_not_form_a_triangle() // To verify triangle sides 0,0,0 should not form a valid triangle
        {
            Assert.AreEqual(null, TriangleSolver.analyze(0, 0, 0));//assert
        }

        [Test]
        public void TC03_To_verify_that_negative_value_of_sides_will_not_form_equilateral_triangle() // To verify negative value sides -2,-2,-2 should not form an equilateral triangle
        {
            Assert.AreEqual(null, TriangleSolver.analyze(-2, -2, -2));//assert
        }
        [Test]
        public void TC04_To_verify_that_negative_value_of_sides_will_not_form_isosceles_triangle() // To verify negative value sides -4,-4,-3 should not form an isosceles triangle
        {
            Assert.AreEqual(null, TriangleSolver.analyze(-4, -4, -3));//assert
        }
        [Test]
        public void TC05_To_verify_that_negative_value_of_sides_will_not_form_scalene_triangle() // To verify negative value sides -2,-3,-4 should not form a scalene triangle
        {
            Assert.AreEqual(null, TriangleSolver.analyze(-2, -3, -4));//assert
        }

        [Test]
        public void TC06_To_verify_if_2_2_2_will_form_equilateral_triangle() // To verify negative value sides 2,2,2 should form an equilateral triangle
        {
            Assert.AreEqual(eq, TriangleSolver.analyze(2, 2, 2));//assert
        }

        [Test]
        public void TC07_To_verify_if_4_4_3_will_form_isosceles_triangle() // To verify negative value sides 4,4,3 should form an isosceles triangle
        {
            Assert.AreEqual(iso, TriangleSolver.analyze(4, 4, 3));//assert
        }

        [Test]
        public void TC08_To_verify_if_1_3_4_will_form_scalene_triangle() // To verify negative value sides 1,3,4 should form a scalene triangle
        {
            Assert.AreEqual(sc, TriangleSolver.analyze(2, 3, 4));//assert
        }

    }d
}

