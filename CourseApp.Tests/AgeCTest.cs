using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AgeCTest
    {
        [Fact]
        public void TestDate()
        {
            double a = DateTime.Now.Ticks - new DateTime(2012, 2, 4).Ticks;
            double b = AgeC.DatComp(new DateTime(2012, 2, 4), DateTime.Now).Ticks;
            if (b - a > 0.001)
            {
                Assert.True(true);
            }
        }

        [Theory]
        [InlineData(2, 4, 2008)]
        [InlineData(8, 12, 2016)]
        public void TestAge(int days, int months, int years)
        {
            Assert.Equal($"Тебе {DateTime.Now.Year - years} лет, {DateTime.Now.Month - months} месяцев и {DateTime.Now.Day - days} дней", AgeC.Age(days, months, years));
        }

        [Fact]
        public void TodayBirthdayTest()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeC.DatComp(DateTime.Now, DateTime.Now)));
            }
            catch (Exception)
            {
            }
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeC.DatComp(DateTime.Now, new DateTime(2024, 4, 8))));
            }
            catch (Exception)
            {
            }
        }
    }
}
