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

        private static void Opener()
        {
            Console.WriteLine("Calling the private opener");
        }

        public void DescribeMe()
        {
            Opener();
            Console.WriteLine("I am  " + AnimalType + " I am a " + AnimalName);
        }

    }
}
