using System;

namespace CourseApp
{
    public abstract class Vehicle
    {
        private int age;

        public Vehicle()
        : this("Неизвестно")
        {
        }

        public Vehicle(string model)
            : this(model, 0)
        {
        }

        public Vehicle(string model, int age)
        {
            Model = model;
            Age = age;
        }

        public virtual int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string Model { get; set; }

        public override string ToString()
        {
            return $"Модель:{Model}, Возраст:{Age}";
        }

        public void Use()
        {
            this.Age++;
        }

        public abstract void Sound();
    }
}