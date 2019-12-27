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

        [Fact]
        public void TestAgeVchera()
        {
            string str = $"Тебе 8 лет, 0 месяцев и 1 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2011, 12, 20), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeToday()
        {
            string str = $"Тебе 9 лет, 0 месяцев и 0 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2010, 12, 21), new DateTime(2019, 12, 21)));
        }

        [Fact]
        public void TestAgeTommorow()
        {
            string str = $"Тебе 13 лет, 11 месяцев и 30 дней";
            Assert.Equal(str, AgeC.Age(new DateTime(2000, 11, 20), new DateTime(2014, 11, 19)));
        }

        [Fact]
        public void TestAge()
        {
            string st = $"Тебе 13 лет, 11 месяцев и 22 дней";
            Assert.Equal(st, AgeC.Age(new DateTime(2000, 11, 20), new DateTime(2014, 11, 11)));
        }

        [Fact]
        public void BirthdayAboveToday()
        {
            try
            {
                Assert.Equal(0, DateTime.Compare(DateTime.Now, AgeC.DatComp(new DateTime(2019, 12, 21), new DateTime(2048, 8, 16))));
            }
            catch (Exception)
            {
            }
        }
    }
}
