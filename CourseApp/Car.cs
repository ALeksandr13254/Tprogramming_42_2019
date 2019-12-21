using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Car : Vehicle
    {
        private int speed;

        public Car()
        : base("Неизвестно")
        {
        }

        public Car(string model)
        : base(model, 0)
        {
        }

        public Car(string model, int age)
        : this(model, age, 0)
        {
        }

        public Car(string model, int age, int speed)
        {
            Model = model;
            Age = age;
            Speed = speed;
        }

        public override int Age
        {
            set
            {
                if (value >= 0 && value <= 20)
                {
                    base.Age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                if (value >= 0)
                {
                    this.speed = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public override string ToString()
        {
            return $"Модель:{Model}, Возраст:{Age}, Скорость:{Speed}";
        }

        public override void Sound()
        {
            Console.WriteLine("Врум!");
        }

        public void Braking()
        {
            this.speed--;
        }
    }
}