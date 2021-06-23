using System;

namespace Exercise3_2
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }
        public Bird(string name, int age, int weight, int wingSpan) : base(name, age, weight)
        {
            WingSpan = wingSpan;
        }
        public override void Dosound()
        {
            Console.WriteLine($"The sound that a {GetType().Name} makes is a chirp"); ;
        }
    }

}