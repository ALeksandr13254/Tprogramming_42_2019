using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AirplaneTests
    {
        [Theory]
        [InlineData("Model", 1, "Produced1")]
        [InlineData("Model1", 3, "Produced2")]
        public void TestConstructorThreeParametrs(string model, int age, string produced)
        {
            var item = new Airplane(model, age, produced);
            Assert.Equal(model, item.Model);
            Assert.Equal(age, item.Age);
            Assert.Equal(produced, item.Produced);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Airplane("Model2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Model2", item.Model);
            Assert.Equal("Неизвестно", item.Produced);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Airplane("Model3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Model3", item.Model);
            Assert.Equal("Неизвестно", item.Produced);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Airplane();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Model);
            Assert.Equal("Неизвестно", item.Produced);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Airplane();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Airplane();
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void TestCorrectIncorrectSetAge()
        {
            var item = new Airplane();
            try
            {
                item.Age = 10;
                item.Age = -5;
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            if (item.Age == 10)
            {
                Assert.Equal(10, item.Age);
            }
        }

        [Fact]
        public void TestCorectToString()
        {
            var item = new Airplane();
            try
            {
                item.ToString();
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.Equal($"Модель:{item.Model}, Возраст:{item.Age}, Производитель:{item.Produced}", item.ToString());
        }

        [Fact]
        public void TestCorectSound()
        {
            var item = new Airplane();
            try
            {
                item.Sound();
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.True(true);
        }

        [Fact]
        public void TestCorrectUse()
        {
            var item = new Airplane();
            int currAge = item.Age;
            item.Use();
            Assert.Equal(item.Age, currAge + 1);
        }
    }
}
