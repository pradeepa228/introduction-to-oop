using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPExercise3
{
    public class Bird
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Speak()
        {
            Console.WriteLine($"My name is {Name} and I am a {Color} bird.");
        }

        public void Fly()
        {
            Console.WriteLine($"I'm {Name} and I can fly high in the blue sky!");
        }
    }
    public class Pigeon : Bird
    {
       public Pigeon(string name, string color) : base(name, color)
        {
        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }
    }
}