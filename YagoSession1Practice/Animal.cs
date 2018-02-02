using System;
using System.Collections.Generic;
using System.Text;

namespace YagoSession1Practice
{
    public class Animal
    {
        public string AnimalType { get; private set; }
        public string AnimalName { get; private set; }


        //name of constructor has to be name of class
        public Animal(string type, string name)
        {
            this.AnimalType = type;
            this.AnimalName = name;
        }

        public Animal(string type) : this(type, "John")
        { }

        //cannot have this plus other default constructor which gives one default argument
        //public Animal(string name) : this("Moonpig", name)
       // { }

        public Animal() : this("Snakes", "Penface")
        { }

        private static void Opener()
        {
            Console.WriteLine("Calling the private opener");
        }

        public void DescribeMe()
        {
            Opener();
            Console.WriteLine("I am  " + AnimalType + " I am a " + AnimalName);
        }

        public void ChangeValue(string value)
        {
            this.AnimalType = value;
            Console.WriteLine("My type has now changed: I am  " + AnimalType + " I am a " + AnimalName);
        }

    }
}
