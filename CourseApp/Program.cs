using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public class Program
    {
        public static double FuncthionZnach(double x)
        {
            double result = Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 0.25) + Math.Pow(Math.Log10(Math.Pow(x, 2)), 0.33);
            return result;
        }

        public static List<double> FuncthionForShag(double x_natch, double x_konch, double x_shag)
        {
            List<double> result = new List<double>();
            for (double i = x_natch; i <= x_konch; i += x_shag)
            {
                result.Add(FuncthionZnach(i));
            }

            if (x_natch > x_konch)
            {
                throw new System.ArgumentOutOfRangeException();
            }

            return result;
        }

        public static List<double> FuncthionForMass(List<double> x)
        {
            List<double> y = new List<double>();
            for (var i = 0; i < x.Count; i++)
            {
                y.Add(FuncthionZnach(x[i]));
            }

            return y;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Задание A:");
            foreach (double element in FuncthionForShag(1.25, 3.25, 0.4))
            {
                Console.WriteLine(element);
            }

            Console.WriteLine($"\nЗадание B:");
            List<double> x = new List<double> { 1.84, 2.71, 3.81, 4.56, 5.62 };
            foreach (var element in FuncthionForMass(x))
            {
                Console.WriteLine($"y = {element}");
            }

            Vehicle[] objects = new Vehicle[2];
            objects[0] = new Car("ModelCar", 3, 3);
            objects[1] = new Airplane("ModelAirplane", 5, "Produced");
            foreach (var item in objects)
            {
                item.Sound();
            }
        }
    }
}