using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPExercise5
{

    public interface IDance
    {
        void Spin();
        void DoTheCaterpillar();
        void Jump();
    }

    public abstract class Bird : IDance
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public Bird(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Speak();

        public virtual void Fly()
        {
            Console.WriteLine($"Hi there! I can fly.");
        }

        public void Spin()
        {
            Console.WriteLine($"{Name} spin!");
        }

        public void DoTheCaterpillar()
        {
            Console.WriteLine($"{Name} do the wriggly woo!");
        }

        public void Jump()
        {
            Console.WriteLine($"{Name} jump in the air!");
        }
    }
    public class Pigeon : Bird
    {
        public Pigeon(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }


        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

    }

    public class Penguin : Bird
    {
        public Penguin(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I'm a {Color} penguin.");
        }

        public override void Fly()
        {
            Console.WriteLine($"Whoops, I can't fly. Waddle waddle.");
        }
    }   
}