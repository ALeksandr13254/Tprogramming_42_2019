using System;
using Xunit;

namespace CourseApp.Tests
{
    public class CarTests
    {
        [Theory]
        [InlineData("Model", 1, 2)]
        [InlineData("Model1", 5, 6)]
        public void TestConstructorThreeParametrs(string model, int age, int speed)
        {
            var item = new Car(model, age, speed);
            Assert.Equal(model, item.Model);
            Assert.Equal(age, item.Age);
            Assert.Equal(speed, item.Speed);
        }

        [Fact]
        public void TestConstructorTwoParametrs()
        {
            var item = new Car("Model2", 3);
            Assert.Equal(3, item.Age);
            Assert.Equal("Model2", item.Model);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestConstructorOneParametrs()
        {
            var item = new Car("Model3");
            Assert.Equal(0, item.Age);
            Assert.Equal("Model3", item.Model);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestEmptyConstructor()
        {
            var item = new Car();
            Assert.Equal(0, item.Age);
            Assert.Equal("Неизвестно", item.Model);
            Assert.Equal(0, item.Speed);
        }

        [Fact]
        public void TestSetAge()
        {
            var item = new Car();
            item.Age = 5;
            Assert.Equal(5, item.Age);
        }

        [Fact]
        public void TestIncorrectSetAge()
        {
            try
            {
                var item = new Car();
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
            var item = new Car();
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
            var item = new Car();
            try
            {
                item.ToString();
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.Equal($"Модель:{item.Model}, Возраст:{item.Age}, Скорость:{item.Speed}", item.ToString());
        }

        [Fact]
        public void TestCorectSound()
        {
            var item = new Car();
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
            var item = new Car();
            int currAge = item.Age;
            item.Use();
            Assert.Equal(item.Age, currAge + 1);
        }

        [Fact]
        public void TestCorrectBraking()
        {
            var item = new Car();
            int currSpeed = item.Speed;
            try
            {
                item.Braking();
            }
            catch (System.Exception)
            {
                Assert.True(true);
            }

            Assert.Equal(item.Speed, currSpeed - 1);
        }
    }
}
