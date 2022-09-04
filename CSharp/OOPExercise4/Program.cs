
using OOPExercise4;

namespace OOPExercise4
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Pigeon pippa = new Pigeon("Pippa", "Grey");
            pippa.Speak();
            pippa.Fly();
            pippa.EatPizza();

            Penguin pingu = new Penguin("Pingu", "Black & White");
            pingu.Speak();
            pingu.Fly();

            Parrot Keeki = new Parrot("Keeki", "Green");
            Keeki.Speak();

        }
    }

}


