using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Airplane : Vehicle
    {
        public Airplane()
        : this("Неизвестно")
        {
        }

        public Airplane(string model)
        : this(model, 0)
        {
        }

        public Airplane(string model, int age)
        : this(model, age, "Неизвестно")
        {
        }

        public Airplane(string model, int age, string produced)
        : base(model, age)
        {
            Produced = produced;
        }

        public override int Age
        {
            set
            {
                if (value >= 0 && value < 10)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public string Produced { get; set; }

        public override string ToString()
        {
            return $"Модель:{Model}, Возраст:{Age}, Производитель:{Produced}";
        }

        public override void Sound()
        {
            Console.WriteLine("ШФРУХХТТТ!");
        }
    }
}