using System;
using System.Collections.Generic;

namespace CourseApp
{
    public class AgeC
    {
        public static string Age()
        {
            Console.WriteLine("Напиши год своего рождения:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напиши месяц своего рождения:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Напиши день своего рождения:");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime res = DatComp(new DateTime(year, month, day), DateTime.Now);
            return $"Тебе {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дней";
        }

        public static string Age(int day, int month, int year)
        {
            DateTime res = DatComp(new DateTime(year, month, day), DateTime.Now);
            return $"Тебе {res.Year - 1} лет, {res.Month - 1} месяцев и {res.Day - 1} дней";
        }

        public static DateTime DatComp(DateTime dat1, DateTime dat2)
        {
            if (dat1.Ticks < dat2.Ticks)
            {
                var res = new DateTime(dat2.Ticks - dat1.Ticks);
                return res;
            }

            throw new Exception();
        }

        public static string Age(DateTime dat)
        {
            var datComp = DatComp(dat, DateTime.Now);
            return $"Тебе {datComp.Year - 1} лет, {datComp.Month - 1} месяцев и {datComp.Day - 1} дней";
        }
    }
}
