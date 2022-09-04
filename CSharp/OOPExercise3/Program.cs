// See https://aka.ms/new-console-template for more information
using OOPExercise3;

namespace OOPExercise3
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Bird myBird = new Bird("Tweety", "Yellow");
            myBird.Speak();
            myBird.Fly();

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();
            pippa.Sleep();

        }
    }

}


