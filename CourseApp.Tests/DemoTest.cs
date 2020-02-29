using System;
using System.Collections.Generic;
using Xunit;

namespace CourseApp.Tests
{
    public class DemoTest
    {
        [Fact]
        public void Test()
        {
            Assert.True(true);
        }

        [Theory]
        [InlineData(1, 1.10668191970032)]
        [InlineData(2, 1.95250809998776)]
        public void TestFuncthionZnach(double x, double e)
        {
            Assert.Equal(e, Program.FuncthionZnach(x), 3);
        }

        [Fact]
        public void TestZeroFuncthionZnach()
        {
            var res = Program.FuncthionZnach(0.0);
            Assert.Equal(double.PositiveInfinity, res);
        }

        [Fact]
        public void TestNullMassFuncthionForMass()
        {
            List<double> mass = new List<double>();
            var res = Program.FuncthionForMass(mass);
            Assert.Equal(mass, res);
        }

        [Fact]
        public void TestFuncthionForMass()
        {
            List<double> x = new List<double> { 1.84, 2.71, 3.81, 4.56, 5.62 };
            List<double> res = Program.FuncthionForMass(x);
            List<double> expY = new List<double> { 1.78088177902672, 2.43716358850851, 2.91258396550454, 3.16349459673976, 3.46531788233977 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expY[i], res[i], 3);
            }
        }

        [Fact]
        public void TestFuncthionForShag()
        {
            List<double> res = Program.FuncthionForShag(1.25, 3.25, 0.4);
            List<double> expY = new List<double> { 1.56588571985763, 1.44658878557922, 1.99793116855463, 2.28865514120997, 2.50911171305746 };
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expY[i], res[i], 3);
            }
        }

        [Fact]
        public void TestFuncthionForShagSupplement()
        {
            try
            {
                List<double> res = Program.FuncthionForShag(1.25, 3.25, 4);
                List<double> expY = new List<double> { 1.56588571985763, 1.44658878557922, 1.99793116855463, 2.28865514120997, 2.50911171305746 };
                for (int i = 0; i < 5; i++)
                {
                    Assert.Equal(expY[i], res[i], 3);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestFuncthionForShagError()
        {
            try
            {
                List<double> res = Program.FuncthionForShag(3.25, 1.25, 0.4);
                List<double> expY = new List<double> { 1.56588571985763 };
                Assert.Equal(expY[0], res[0], 3);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Assert.True(true);
            }
        }
    }
}
